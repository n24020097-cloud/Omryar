using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Omryar.Domain
{
    public class ValidatorDrug
    {
        public OperationResult Validate(DrugDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.DrugName))
                return OperationResult.Failed(Messages.DrugMessages.DrugNameRequired);

            if (dto.DrugName.Length < 2)
                return OperationResult.Failed(Messages.DrugMessages.DrugNameLength);

            if (dto.RepeatValue <= 0)
                return OperationResult.Failed(Messages.DrugMessages.InvalidRepeatValue);

            if (dto.DrugQty < 0)
                return OperationResult.Failed(Messages.DrugMessages.InvalidDrugQuantity);

            if (dto.LastTakenTime == null)
                return OperationResult.Failed(Messages.DrugMessages.LastTakenTimeRequired);

            if (dto.LastTakenTime > DateTime.Now)
                return OperationResult.Failed(Messages.DrugMessages.InvalidLastTakenTime);

            return OperationResult.Success();
        }
    }
}
