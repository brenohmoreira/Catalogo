﻿namespace APICatalogo.Domains
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        // Relacionamento com a categoria
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
