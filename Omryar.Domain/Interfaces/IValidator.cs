using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IValidator<T>
    {
        OperationResult Validate(T dto);
    }
}
