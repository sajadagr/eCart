using ECart.Business.Service.Interface;
using ECart.Data.Models;
using ECart.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Business.Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task Delete(Country country)
        {
            await _countryRepository.Delete(country);
            await _countryRepository.Save();
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            return await _countryRepository.GetAll();
        }

        public async Task<Country> GetByID(long id)
        {
            return await _countryRepository.GetByID(id);
        }

        public async Task<Country> Upsert(long? id, Country country)
        {
            Country obj;
            if (id == null)
                obj = await _countryRepository.Insert(country);
            else
            {
                var dbCountry = await _countryRepository.GetByID((long)id);
                dbCountry.Name = country.Name;
                dbCountry.PhoneCode = country.PhoneCode;
                dbCountry.SortName = country.SortName;
                obj = _countryRepository.Update(dbCountry);
            }
            await _countryRepository.Save();
            return obj;
        }
    }
}
