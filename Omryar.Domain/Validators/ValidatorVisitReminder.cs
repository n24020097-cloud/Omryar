using Omryar.Domain.DTOs;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Validators
{
    public class ValidatorVisitReminder
    {
        public OperationResult Validate(VisitReminderDto dto)
        {
            if (dto == null)
                return OperationResult.Failed(Messages.VisitMessages.VisitValidationFailed);

            if (string.IsNullOrWhiteSpace(dto.DoctorName))
                return OperationResult.Failed(Messages.VisitMessages.DoctorNameRequired);

            if (string.IsNullOrWhiteSpace(dto.Specialty))
                return OperationResult.Failed(Messages.VisitMessages.SpecialtyRequired);

            if (dto.VisitDateTime == default)
                return OperationResult.Failed(Messages.VisitMessages.InvalidVisitDate);

            if (dto.VisitDateTime < DateTime.Now)
                return OperationResult.Failed(Messages.VisitMessages.PastVisitDate);

            return OperationResult.Success();
        }
    }
}
