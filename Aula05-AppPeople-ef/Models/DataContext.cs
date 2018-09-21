using AppPeople.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula04_AppPeople_ef.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}

        public DbSet<Person> Person { get; set; }

    }
}