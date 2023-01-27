using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Models;
namespace WebEscuelaMVC.Data
{
    public class EscuelaDbContext : DbContext
    {

        public EscuelaDbContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<Aula> Aulas { get; set; }

    }
}
