using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.DTOs.PersonDtos;
using Omryar.Domain.DTOs.Requests;
using Omryar.Domain.Entity;
using Omryar.Domain.Interfaces;
using Omryar.Service.DTOs;
using Omryar.Service.Mappings;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service
{
    public class PersonService:IPersonService
    {
        IPersonRepository _personRepository;
        private readonly IUserSettingRepository _settingRepo;
        public PersonService(IPersonRepository personRepo, IUserSettingRepository settingRepo)
        {
            _personRepository = personRepo;
            _settingRepo = settingRepo;
        }
        public async Task<OperationResult> AddPersonAsync(AddPersonDto p)
        {
            var valid = new ValidatorPerson().Validate(p);
            var person = p.ToEntity();
            var duplicate =await IsDuplicateAsync(person);
            if (!valid.IsSuccess)
                return OperationResult.Failed(valid.Message);
            if (!duplicate.IsSuccess)
                return OperationResult.Failed(duplicate.Message);
            person.PasswordHash = HashHelper.ComputeSha256(p.Password);
            await _personRepository.AddAsync(person);
            await CreateDefaultSettings(person);
            return OperationResult.Success();
        }
        private async Task CreateDefaultSettings(Person person)
        {
            var setting = new UserSetting
            {
                PersonId = person.Id,
                Bio = "",
                Theme = "Light",
                FontSize = 10,
                IsProfilePublic = false,
                EnableVisitReminder = true,
                EnableMedicineReminder = true
            };

            await _settingRepo.AddAsync(setting);
        }
        public async Task<OperationResult> DeletePersonAsync(int id)
        {
            if(await _personRepository.MarkAsDeletedAsync(id) ==true)
                return OperationResult.Success();
            return OperationResult.Failed(Messages.PersonNotFound);
        }

        public async Task<OperationResult<CurrentUserDto>> GetByIdPersonAsync(int id)
        {
            var existingitem=await _personRepository.GetByIdAsync(id);
            if (existingitem == null)
                return OperationResult<CurrentUserDto>.Failed(Messages.PersonNotFound);
            return OperationResult<CurrentUserDto>.Success("",existingitem.ToPersnInfoDto());
        }
        public async Task<OperationResult<List<Person>>> SelectPeopleAsync()
        {
            var list= await _personRepository.SelectPeopleAsync();
            if (list == null)
                return OperationResult<List<Person>>.Failed(Messages.PersonlistIsEmpty);
            return OperationResult<List<Person>>.Success("", list);
        }
        public async Task<OperationResult<Person>> GetByUserNameAsync(string username)
        {
            var existingitem = await _personRepository.GetByUserNameAsync(username);
            if (existingitem == null)
                return OperationResult<Person>.Failed(Messages.PersonNotFound);
            return OperationResult<Person>.Success("", existingitem);
        }

        public async Task<OperationResult<CurrentUserDto>> LoginAsync(string username,string password)
        {
            var p =await GetByUserNameAsync(username);
            var hashed = HashHelper.ComputeSha256(password);
            if ( !p.IsSuccess)
                return OperationResult<CurrentUserDto>.Failed(Messages.UserNameNotFound);
            if (p.Data.PasswordHash!= hashed)
                return OperationResult<CurrentUserDto>.Failed(Messages.WrongPassword);
            return OperationResult<CurrentUserDto>.Success("",p.Data.ToPersnInfoDto());
        }

        public async Task<OperationResult> IsDuplicateAsync(Person p)
        {
            if(await _personRepository.IsDuplicateNationalCodeAsync(p.NationalCode))
                return OperationResult.Failed(Messages.NationalCodeMessages.DuplicateNationalCode);

            if (await _personRepository.IsDuplicateUserNameAsync(p.UserName))
                return OperationResult.Failed(Messages.UserNameMessages.DuplicateUserName);

            return OperationResult.Success();
        }
        public async Task<OperationResult> ChangePasswordAsync(ChangePasswordDto dto)
        {
            var person = await _personRepository.GetByIdAsync(dto.PersonId);

            if (person == null)
                return OperationResult.Failed(Messages.PersonNotFound);

            if (person.PasswordHash !=HashHelper.ComputeSha256(dto.CurrentPassword))
                return OperationResult.Failed(Messages.PasswordMessages.WrongPassword);

            person.PasswordHash = HashHelper.ComputeSha256(dto.NewPassword);

            await _personRepository.UpdateAsync(person);

            return OperationResult.Success(Messages.PasswordMessages.PasswordChanged);
        }
    }
}
