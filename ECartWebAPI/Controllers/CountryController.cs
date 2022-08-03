using ECart.Business.Service.Interface;
using ECart.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: api/<CountryController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _countryService.GetAll();
            if (countries == null)
                return NotFound();
            else
                return Ok(countries);
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var country = await _countryService.GetByID(id);
            if (country == null)
                return NotFound();
            else
                return Ok(country);
        }

        // POST api/<CountryController>
        [HttpPost]
        public async Task<IActionResult> Post(long? id, [FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var objCountry = await _countryService.Upsert(id, country);
            return Ok(country);

        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Country>> Delete(int id)
        {
            var country = await _countryService.GetByID(id);
            if (country == null)
                return NotFound();
            else
            {
                await _countryService.Delete(country);
                return NoContent();
            }
        }
    }
}
