using Microsoft.EntityFrameworkCore.Migrations;
using VitalFitAppWeb.Models;

#nullable disable

namespace VitalFitAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new VitalFitDbContext();
            context.Produto.AddRange(ObterCargaInicialProduto());
            context.SaveChanges();
        }

        private IList<Produto> ObterCargaInicialProduto()
        {
            return new List<Produto>()
        {
            new Produto
            {
                Nome = "conjunto 1",
                Descricao = "Roupa para treino anti-odor, super confortável, tecido leve.",
                ImagemUrl = "/images/roupas/conjunto1.jpg",
                ProdutoTipo = "roupa",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "conjunto 2",
                Descricao = "Roupa para treino anti-odor, super confortável, tecido leve.",
                ImagemUrl = "/images/roupas/conjunto2.jpg",
                ProdutoTipo = "roupa",
                Preco = 59.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "conjunto 3",
                Descricao = "Roupa para treino anti-odor, super confortável, tecido leve.",
                ImagemUrl = "/images/roupas/conjunto3.jpg",
                ProdutoTipo = "roupa",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Equipamento 1",
                Descricao = "Ketlebell 20kg",
                ImagemUrl = "/images/equipamentos/ktb.jpg",
                ProdutoTipo = "equipamento",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Equipamento 2",
                Descricao = "Barra olimpica masculina 20kg",
                ImagemUrl = "/images/equipamentos/barras.jpg",
                ProdutoTipo = "equipamento",
                Preco = 59.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Equipamento 3",
                Descricao = "Peso de 20kg",
                ImagemUrl = "/images/equipamentos/pesos.jpg",
                ProdutoTipo = "equipamento",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Acessório 1",
                Descricao = "Corda super resistente e leve, ótima para quem está iniciando no salto de corda",
                ImagemUrl = "/images/acessorios/corda.jpg",
                ProdutoTipo = "acessorio",
                Preco = 89.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Acessório 2",
                Descricao = "Bands elasticas para treinos funcionais, fisioterapia, pilates",
                ImagemUrl = "/images/acessorios/band.jpg",
                ProdutoTipo = "acessorio",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
            new Produto
            {
                Nome = "Acessório 3",
                Descricao = "Luva para treino",
                ImagemUrl = "/images/acessorios/luva.jpg",
                ProdutoTipo = "acessorio",
                Preco = 79.90,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now
            },
        };
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
