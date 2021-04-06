using Microsoft.EntityFrameworkCore;

namespace Teste.Models{

    public class Context : DbContext {

        public Context(){}

        public Context(DbContextOptions<Context> options) : base(options){
            Database.EnsureCreated();
        }

        public DbSet<Comentario> comentario { get; set; }
    }

}