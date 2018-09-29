using Microsoft.EntityFrameworkCore;

namespace AppConsulta.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {}

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}