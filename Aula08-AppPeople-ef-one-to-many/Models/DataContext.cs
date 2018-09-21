using AppPeople.Models;
using Aula05_AppPeople_ef_one_to_many.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula04_AppPeople_ef.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}