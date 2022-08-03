using ECart.Data.Models;
using ECart.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Repository
{
    public class CountryRepository : ICountryRepository
    {
        ECartContext _context;
        public CountryRepository(ECartContext context)
        {
            _context = context;
        }

        public async Task Delete(Country country)
        {
            if (country != null)
                await Task.Run(() => _context.Countries.Remove(country));
                //await Task.Run(() => {
                //    _context.Countries.Remove(country);
                //});
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetByID(long id)
        {
            var country = await _context.Countries.FindAsync(id);//.FirstOrDefaultAsync(a => a.ID == id);
            return country;
        }

        public async Task<Country> Insert(Country country)
        {
            await _context.Countries.AddAsync(country);
            return country;
        }

        public Country Update(Country country)
        {
            _context.Countries.Update(country);
            return country;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
