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
        Task Add(Drug drug);
        Task<Drug> Update(int id);
        Task Delete(int id);
        Task UpdateAndSaveChanges();
        Task<List<DrugDto>> Select(int id);
        Task<List<Drug>> SelectForReminder(int id);
        Task<List<Drug>> GetDrugs();
    }
}
