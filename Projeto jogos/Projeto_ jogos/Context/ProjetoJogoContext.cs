using Microsoft.EntityFrameworkCore;
using Projeto__jogos.Domains;

namespace Projeto__jogos.Context
{
    public class ProjetoJogoContext : DbContext
    {
        //Metodo construtor tem o mesmo nome da classe:
        public ProjetoJogoContext() { }
        public ProjetoJogoContext(DbContextOptions<ProjetoJogoContext> options) : base(options)
        {

        }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE08-S28\\SQLEXPRESS Database=Jogos; User id = sa; Pwd=abc123 ; TrustServerCertificate=true;");
            }
        }
       }

         }
