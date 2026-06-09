using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Domain.Interfaces;
using Omryar.Service.Mappings;
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

        public async Task<OperationResult> AddDrugAsync(DrugDto drugDto)
        {
            var valid=new ValidatorDrug().Validate(drugDto);
            if (!valid.IsSuccess)
                return OperationResult.Failed(valid.Message);
            var Duplicate =await IsDuplicateAsync(drugDto);
            if (!Duplicate.IsSuccess)
                return OperationResult.Failed(Duplicate.Message);
            var drug = drugDto.ToEntity();
            await _drugRepository.AddAsync(drug);
            return OperationResult.Success();
        }

        public async Task DeleteDrugAsync(int id)
        {
            await _drugRepository.DeleteAsync(id);
            
        }

        public async Task<OperationResult<DrugDto>> GetDrugByIdAsync(int id)
        {
            var existingItem =await _drugRepository.GetDrugByIdAsync(id);
            if(existingItem == null)
                return OperationResult<DrugDto>.Failed(Messages.DrugMessages.DrugNotFound);
            return OperationResult<DrugDto>.Success("", existingItem.ToDto());
        }

        public async Task<List<DrugDto>> GetDrugsByPersonIdAsync(int personId)
        {
            var list=await _drugRepository.GetDrugsByPersonIdAsync(personId);
            return list.Select(d => d.ToDto()).ToList();
        }

        public async Task<OperationResult> UpdateDrugAsync(DrugDto drugDto)
        {
            var existingItem = await _drugRepository.UpdateAsync(drugDto.ToEntity());
            if(!existingItem) 
                return OperationResult.Failed(Messages.DrugMessages.DrugNotFound);
            return OperationResult.Success();
        }
        public async Task<OperationResult> IsDuplicateAsync(DrugDto drugDto)
        {
            var existingItem=await _drugRepository.IsDuplicateAsync(drugDto.ToEntity());
            if (existingItem)
                return OperationResult.Failed(Messages.DrugMessages.DuplicateDrug);
            return OperationResult.Success();
        }

    }
}
