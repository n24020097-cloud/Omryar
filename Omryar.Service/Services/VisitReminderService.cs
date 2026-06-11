using Omryar.Domain.DTOs;
using Omryar.Domain.Interfaces;
using Omryar.Domain.Validators;
using Omryar.Service.Mappings;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Services
{
    public class VisitReminderService:IVisitService
    {
        private IVisitRepository _visitRepo;
        IValidator<VisitReminderDto> _validator;

        public VisitReminderService(IVisitRepository visitRepo,IValidator<VisitReminderDto> validator)
        {
            _visitRepo = visitRepo;
            _validator = validator;
        }

        public async Task<OperationResult> AddAsync(VisitReminderDto dto)
        {
            var validate = _validator.Validate(dto);

            if (!validate.IsSuccess)
                return OperationResult.Failed(validate.Message);

            await _visitRepo.AddAsync(dto.ToEntity());
            return OperationResult.Success(Messages.VisitMessages.VisitAdded);
        }

        public async Task<OperationResult> UpdateAsync(VisitReminderDto dto)
        {
            var validate = _validator.Validate(dto);
            if (!validate.IsSuccess)
                return OperationResult.Failed(validate.Message);
            var result = await _visitRepo.UpdateAsync(dto.ToEntity());

            if (!result)
                return OperationResult.Failed(Messages.VisitMessages.VisitNotFound);

            return OperationResult.Success(Messages.VisitMessages.VisitUpdated);
        }

        public async Task<OperationResult> DeleteAsync(int id)
        {
            var result = await _visitRepo.GetByIdAsync(id);
            if (result==null)
                return OperationResult.Failed(Messages.VisitMessages.VisitNotFound);
            if (result.VisitDateTime < DateTime.Now)
                return OperationResult.Failed(Messages.VisitMessages.VisitTimeHasNotArrived);
            return OperationResult.Success(Messages.VisitMessages.VisitDeleted);
        }

        public async Task<OperationResult<VisitReminderDto>> GetByIdAsync(int id)
        {
            var visit = await _visitRepo.GetByIdAsync(id);

            if (visit == null)
                return OperationResult<VisitReminderDto>.Failed(Messages.VisitMessages.VisitNotFound);

            return OperationResult<VisitReminderDto>.Success("", visit.ToDto());
        }

        public async Task<List<VisitReminderDto>> GetByPersonIdAsync(int personId)
        {
            var list = await _visitRepo.GetByPersonIdAsync(personId);
            return list
                .Select(v => v.ToDto())
                .ToList();
        }

        public async Task<List<VisitReminderDto>> GetNext24HoursAsync(int personId)
        {
            var visits = await _visitRepo.GetUpcoming24HoursAsync(personId);

            return visits.Select(v => v.ToDto()).ToList();
        }

        public async Task MarkAsNotifiedAsync(int id)
        {
            await _visitRepo.MarkAsNotifiedAsync(id);
        }
    }
}
