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
        Task<OperationResult> AddDrug(Drug drug, int idForEdit = 0, int currentUser = 0);
        Task<List<DrugDto>> GetDrugsByPersonId(int id);
        Task<List<Drug>> GetDrugs();
        Task DeleteDrug(int id);
        Task<Drug> UpdateDrug(int id);
        Task UpdateAndSaveChanges();
        Task<OperationResult> IsDuplicateDrug(Drug d, int idForEdit, int currentUser);
        Task<List<Drug>> GetDrugsForReminder(int id);
    }
}
