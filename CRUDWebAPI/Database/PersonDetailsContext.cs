using CRUDWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Database
{
    public class PersonDetailsContext : DbContext
    {
        public PersonDetailsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<PersonDetails> PersonDt { get; set; }
    }
}
