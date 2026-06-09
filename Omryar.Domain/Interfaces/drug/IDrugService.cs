using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IDrugService
    {
        Task<OperationResult> AddDrugAsync(DrugDto drugDto);
        Task DeleteDrugAsync(int id);
        Task<OperationResult<DrugDto>> GetDrugByIdAsync(int id);
        Task<List<DrugDto>> GetDrugsByPersonIdAsync(int personId);
        Task<OperationResult> UpdateDrugAsync(DrugDto drugDto);
        Task<OperationResult> IsDuplicateAsync(DrugDto drugDto);

    }
}
