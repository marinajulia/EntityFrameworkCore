using Microsoft.EntityFrameworkCore;
using System;

namespace CursoEFCore_Aula1 {

    //entidade
    class Produto {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
    //classe de contexto

    class AppDbContext : DbContext {
        //mapeamento da entidade para a tabela
        public DbSet<Produto> ProdutosNovo { get; set; } //a tabela vai ter o nome de "Produtos"

        //O Provedor e a string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=Aula1DBNovo;Integrated Security=True");
        }

    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
