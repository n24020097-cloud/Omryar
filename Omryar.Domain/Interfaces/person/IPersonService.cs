using Omryar.Domain.DTOs.PersonDtos;
using Omryar.Domain.DTOs.Requests;
using Omryar.Service.DTOs;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IPersonService
    {
        Task<OperationResult> AddPersonAsync(AddPersonDto p);
        Task<OperationResult> DeletePersonAsync(int id);
        Task<OperationResult<CurrentUserDto>> GetByIdPersonAsync(int id);
        Task<OperationResult<List<Person>>> SelectPeopleAsync();
        Task<OperationResult<Person>> GetByUserNameAsync(string username);
        Task<OperationResult<CurrentUserDto>> LoginAsync(string username, string password);
        Task<OperationResult> IsDuplicateAsync(Person p);
        Task<OperationResult> ChangePasswordAsync(ChangePasswordDto dto);
    }
}
