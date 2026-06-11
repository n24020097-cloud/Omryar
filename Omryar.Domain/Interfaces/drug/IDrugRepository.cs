using Omryar.Domain.DTOs.DrugDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IDrugRepository:IRepository<Drug>
    {
        Task<List<Drug>> GetDrugsByPersonIdAsync(int personId);
        Task<bool> UpdateAsync(Drug drug);
        Task<bool> IsDuplicateAsync(Drug drug);
        Task<List<Drug>> GetTodayDrugsAsync(int personId);
        Task UpdateAfterTakenAsync(int drugId, DateTime takenTime, DateTime nextTokenTime);
        Task<Drug> GetNextDrugAsync(int personId);
    }
}
