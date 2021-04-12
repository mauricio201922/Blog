using System;
using Microsoft.EntityFrameworkCore;

namespace Teste.Models{

    public class Context : DbContext {

        public Context(){}

        public Context(DbContextOptions<Context> options) : base(options){
        }

        public DbSet<Comentario> comentario { get; set; }
    }

}