using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IPersonRepository:IRepository<Person>
    {
        Task<List<Person>> SelectPeopleAsync();
        Task<Person> GetByUserNameAsync(string userName);
        Task<bool> IsDuplicateNationalCodeAsync(String nationalCode);
        Task<bool> IsDuplicateUserNameAsync(string username);
        Task<bool> UpdateAsync(Person person);
    }
}
