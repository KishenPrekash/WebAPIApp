using CRUDWebAPI.Database;
using CRUDWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonDtController : ControllerBase
    {
        private readonly PersonDetailsContext _context;
        public PersonDtController(PersonDetailsContext persondetailsContext)
        { 
            this._context = persondetailsContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson() 
        {
           var pd = await _context.PersonDt.ToListAsync();

           return Ok(pd);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody]PersonDetails pdt)
        {
            pdt.id = new int();

            await _context.PersonDt.AddAsync(pdt);
            await _context.SaveChangesAsync();
            return Ok(pdt);
        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdatePerson([FromRoute] int id,[FromBody] PersonDetails pdt)
        {
           var person= await _context.PersonDt.FirstOrDefaultAsync(a => a.id == id);

           if (person != null)
            {
                person.username = pdt.username;
                person.email = pdt.email;
                person.phoneNumber = pdt.phoneNumber;
                person.skillSet = pdt.skillSet;
                person.hobby = pdt.hobby;

                await _context.SaveChangesAsync();
                return Ok(pdt);

            }
            else
            {
                return NotFound("Employee Not Found");
            }
                
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeletePerson([FromRoute] int id)
        {
            var person = await _context.PersonDt.FirstOrDefaultAsync(a => a.id == id);

            if (person != null)
            {
               
               _context.PersonDt.Remove(person);
                await _context.SaveChangesAsync();
                return Ok(person);

            }
            else
            {
                return NotFound("Employee Not Found");
            }

        }
    }
}
