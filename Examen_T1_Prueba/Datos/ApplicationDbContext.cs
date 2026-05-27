using Microsoft.EntityFrameworkCore;
using Examen_T1_Prueba.Models;

namespace Examen_T1_Prueba.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Categoria> Categoria { get; set; }
    }
}