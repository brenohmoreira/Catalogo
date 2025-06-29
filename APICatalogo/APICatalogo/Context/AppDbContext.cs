using APICatalogo.Domains;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    // Uma instância de AppDbContext representa uma sessão com o banco de dados, permitindo que você consulte e salve instâncias de entidades.
    public class AppDbContext : DbContext 
    {
        // base passa para o construtor da classe DbContext que foi extendido, as opções de configuração do contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet representa uma coleção de entidades do tipo Produto
        public DbSet<Produto>? Produtos { get; set; }

        // DbSet representa uma coleção de entidades do tipo Categoria
        public DbSet<Categoria>? Categorias { get; set; }
    }
}
