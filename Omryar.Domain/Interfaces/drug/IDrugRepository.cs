using Omryar.Domain.DTOs.DrugDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IDrugRepository
    {
        Task AddAsync(Drug drug);
        Task DeleteAsync(int id);
        Task<List<Drug>> GetDrugsByPersonIdAsync(int personId);
        Task<Drug> GetDrugByIdAsync(int drugId);
        Task<bool> UpdateAsync(Drug drug);
        Task<bool> IsDuplicateAsync(Drug drug);
    }
}
