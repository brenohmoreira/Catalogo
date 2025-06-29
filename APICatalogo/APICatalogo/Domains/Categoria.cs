using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace APICatalogo.Domains
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }

        // Se for classId ou Id, o EF Core vai entender que é a chave primária
        public int CategoriaId { get; set; }
        
        // ? faz ser nullable
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}
