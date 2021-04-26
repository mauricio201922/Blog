using Microsoft.EntityFrameworkCore;

namespace Teste.Models{

    public class Context : DbContext {

        public Context(){}

        public Context(DbContextOptions<Context> options) : base(options){
        }

        public DbSet<Comentario> comentario { get; set; }
        public DbSet<Login> login { get; set; }
        public DbSet<Contato> contato { get; set; }
    }

}