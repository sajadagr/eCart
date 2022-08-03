using ECart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Business.Service.Interface
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAll();
        Task<Country> GetByID(long id);
        Task<Country> Upsert(long? id, Country country);
        Task Delete(Country country);
    }
}
