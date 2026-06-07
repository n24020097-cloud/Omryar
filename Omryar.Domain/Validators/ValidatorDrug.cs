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
        public OperationResult DrugValidate(Drug drug)
        {
            if (!ValidateName(drug.DrugName).IsSuccess)
                return OperationResult.Failed(ValidateName(drug.DrugName).Message);
            if (!ValidateReminderRepeatValue(drug.ReminderRepeatValue).IsSuccess)
                return OperationResult.Failed(ValidateReminderRepeatValue(drug.ReminderRepeatValue).Message);
            if (!ValidateDosage(drug.Dosage).IsSuccess)
                return OperationResult.Failed(ValidateDosage(drug.Dosage).Message);
           
            return OperationResult.Success();
        }

        public OperationResult ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return OperationResult.Failed(Messages.DrugNameMessage.IsEmptyOrNull);
            if (name.Length < 3)
                return OperationResult.Failed(Messages.DrugNameMessage.InvalidLength);
            return OperationResult.Success();
        }
        public OperationResult ValidateReminderRepeatValue(int rv)
        {
            if (rv == 0)
                return OperationResult.Failed(Messages.DrugRepeatValueMessage.IsEmptyOrNull);
            return OperationResult.Success();
        }
        public OperationResult ValidateDosage(int d)
        {
            if (d == 0)
                return OperationResult.Failed(Messages.DrugDosageMessage.IsEmptyOrNull);
            return OperationResult.Success();
        }


    }
}
