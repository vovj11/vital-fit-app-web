using VitalFitAppWeb.Models;

namespace VitalFitAppWeb.Services.Memory
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoService() => CarregarListaInicial();

        private IList<Produto> _produtos;

        private void CarregarListaInicial()
        {
            _produtos = new List<Produto>()
        {
            new Produto
            {
                ProdutoId = 1,
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
                ProdutoId = 2,
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
                ProdutoId = 3,
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
                ProdutoId = 4,
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
                ProdutoId = 5,
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
                ProdutoId = 6,
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
                ProdutoId = 7,
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
                ProdutoId = 8,
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
                ProdutoId = 9,
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
        public IList<Produto> ObterTodos() => _produtos;

        public Produto Obter(int id)
            => ObterTodos().SingleOrDefault(item => item.ProdutoId == id);

        public void Incluir(Produto produto)
        {
            var proximoId = _produtos.Max(item => item.ProdutoId) + 1;
            produto.ProdutoId = proximoId;
            _produtos.Add(produto);
        }

        public void Alterar(Produto produto)
        {
            var produtoEncontrado = _produtos.SingleOrDefault(item => item.ProdutoId == produto.ProdutoId);
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.ProdutoTipo = produto.ProdutoTipo;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.EntregaExpressa = produto.EntregaExpressa;
            produtoEncontrado.DataCadastro = produto.DataCadastro;
            produtoEncontrado.ImagemUrl = produto.ImagemUrl;
        }

        public void Excluir(int id)
        {
            var produtoEncontrado = Obter(id);
            _produtos.Remove(produtoEncontrado);
        }

        public IList<Marca> ObterTodasMarcas()
        {
            throw new NotImplementedException();
        }

        public Marca ObterMarca(int id)
        {
            throw new NotImplementedException();
        }
    }
}
