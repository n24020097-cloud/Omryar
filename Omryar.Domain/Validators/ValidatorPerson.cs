using Omryar.Domain.Interfaces;
using Omryar.Service.DTOs;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class ValidatorPerson: IValidator<AddPersonDto>
    {
        public OperationResult Validate(AddPersonDto p)
        {
            if(!ValidateFullName(p).IsSuccess)
                return OperationResult.Failed(ValidateFullName(p).Message);
            if (!ValidateMobile(p.Mobile).IsSuccess)
                return OperationResult.Failed(ValidateMobile(p.Mobile).Message);
            if (!ValidateNationalCode(p.NationalCode).IsSuccess)
                return OperationResult.Failed(ValidateNationalCode(p.NationalCode).Message);
            if (!ValidateUserName(p.UserName).IsSuccess)
                return OperationResult.Failed(ValidateUserName(p.UserName).Message);
            if (!ValidatePassword(p.Password).IsSuccess)
                return OperationResult.Failed(ValidatePassword(p.Password).Message);
            return OperationResult.Success();
        }

        private OperationResult ValidateFullName(AddPersonDto p)
        {
            if (string.IsNullOrEmpty(p.FirstName) || string.IsNullOrEmpty(p.LastName))
                return OperationResult.Failed(Messages.FullNameMessages.IsEmptyOrNull);
            if (p.FirstName.Length < 3 || p.LastName.Length<3)
                return OperationResult.Failed(Messages.FullNameMessages.InvalidLength);
            return OperationResult.Success();
        }
        private OperationResult ValidateNationalCode(string nationalCode)
        {
            if(string.IsNullOrEmpty(nationalCode))
                return OperationResult.Failed(Messages.NationalCodeMessages.IsEmptyOrNull);
            if(nationalCode.Length!=10)
                return OperationResult.Failed(Messages.NationalCodeMessages.InvalidLength);
            return OperationResult.Success();
        }
        private OperationResult ValidateMobile(string mobile)
        {
            if (string.IsNullOrWhiteSpace(mobile))
                return OperationResult.Failed(Messages.MobileMessages.IsEmptyOrNull);
            if (mobile.Length != 11)
                return OperationResult.Failed(Messages.MobileMessages.InvalidLength);
            if (!mobile.StartsWith("09"))
                return OperationResult.Failed(Messages.MobileMessages.StartWith);
            if (!mobile.All(char.IsDigit))
                return OperationResult.Failed(Messages.MobileMessages.OnlyNumber);
            return OperationResult.Success();
        }
        private OperationResult ValidateUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return OperationResult.Failed(Messages.UserNameMessages.IsEmptyOrNull);
            if (username.Length < 3 || username.Length > 20)
                return OperationResult.Failed(Messages.UserNameMessages.InvalidLength);
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_-]+$"))
                return OperationResult.Failed(Messages.UserNameMessages.InvalidCharacters);
            if (username.StartsWith("-") || username.StartsWith("_") || username.EndsWith("-") || username.EndsWith("_"))
                return OperationResult.Failed(Messages.UserNameMessages.StartWith);
            return OperationResult.Success();
        }

        private OperationResult ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return OperationResult.Failed(Messages.PasswordMessages.IsEmptyOrNull);
            if (password.Length < 4)
                return OperationResult.Failed(string.Format(Messages.PasswordMessages.TooShort));
            if (!password.Any(char.IsUpper))
                return OperationResult.Failed(Messages.PasswordMessages.RequiresUppercase);
            if (!password.Any(char.IsLower))
                return OperationResult.Failed(Messages.PasswordMessages.RequiresLowercase);
            if (!password.Any(char.IsDigit))
                return OperationResult.Failed(Messages.PasswordMessages.RequiresDigit);
            var specialCharPattern = new Regex(@"[!@#$%^&*()_+\-=`~\[\]\\|;:'"",.<>/?]");
            if (!specialCharPattern.IsMatch(password))
                return OperationResult.Failed(Messages.PasswordMessages.RequiresSpecialChar);
            return OperationResult.Success();
        }
    }
}
