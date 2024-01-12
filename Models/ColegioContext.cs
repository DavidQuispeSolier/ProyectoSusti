using Microsoft.EntityFrameworkCore;

namespace ProyectoSusti.Models
{
    public class ColegioContext: DbContext
    {
        public ColegioContext(DbContextOptions<ColegioContext> options) : base(options)
        {
        }
        public DbSet<Matricula> Matriculas { get; set; }
    
    }
}
