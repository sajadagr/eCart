using ECart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Repository.Interface
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAll();
        Task<Country> GetByID(long id);
        Task<Country> Insert(Country country);
        Country Update(Country country);
        Task Delete(Country country);
        Task Save();
    }
}
