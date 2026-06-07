using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Domain.Interfaces;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service
{
    public class DrugService:IDrugService
    {
        IDrugRepository _drugRepository;

        public DrugService(IDrugRepository drugRepository)
        {
            _drugRepository=drugRepository;
        }
        public async Task<OperationResult> AddDrug(Drug drug,int idForEdit=0,int currentUser=0)
        {
            var valid = new ValidatorDrug();
            var validator = valid.DrugValidate(drug);
            if (!validator.IsSuccess)
                return OperationResult.Failed(validator.Message);
            
            var isDuplicate = await IsDuplicateDrug(drug,idForEdit,currentUser);
            if (isDuplicate.IsSuccess)
                return OperationResult.Failed(isDuplicate.Message);
            if(idForEdit==0)
               await _drugRepository.Add(drug);
            return OperationResult.Success();
            
        }
 
        public async Task<List<DrugDto>> GetDrugsByPersonId(int id)
        {
            return await _drugRepository.Select(id);
        }
        public async Task<List<Drug>> GetDrugsForReminder(int id)
        {
            return await _drugRepository.SelectForReminder(id);
        }
        public async Task<List<Drug>> GetDrugs()
        {
            return await _drugRepository.GetDrugs();
        }
        public async Task DeleteDrug(int id)
        {
            await _drugRepository.Delete(id);
        }
        public async Task<Drug> UpdateDrug(int id)
        {
            return await _drugRepository.Update(id);
        }
        public async Task UpdateAndSaveChanges()
        {
           await _drugRepository.UpdateAndSaveChanges();
        }

        public async Task<OperationResult> IsDuplicateDrug(Drug d,int idForEdit,int currentUser)
        {
            var drug = await SelectDrug(currentUser);
            try
            {
                if(idForEdit == 0)
                {
                    if(drug.Any(x => x.DrugName == d.DrugName))
                    {
                        return OperationResult.Success(Messages.Drug.IsDuplicateDrugName);
                    }
                }
                else
                {
                    var dr = drug
                        .Where(x => x.DrugName == d.DrugName)
                        .Single();
                    if(dr.DrugId!=idForEdit)
                        return OperationResult.Success(Messages.Drug.IsDuplicateDrugName);
                }
                return OperationResult.Failed(Messages.Drug.RecordSuccess);
            }
            catch
            {
                return OperationResult.Failed(Messages.SystemError);
            }
        }
    }
}
