using VitalFitAppWeb.Data;
using VitalFitAppWeb.Models;

namespace VitalFitAppWeb.Services.Data;

public class ProdutoService : IProdutoService
{
    private VitalFitDbContext _context;
    public ProdutoService(VitalFitDbContext context)
    {
        _context = context;
    }
    public void Alterar(Produto produto)
    {
        var produtoEncontrado = Obter(produto.ProdutoId);
        produtoEncontrado.Nome = produto.Nome;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.ProdutoTipo = produto.ProdutoTipo;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.EntregaExpressa = produto.EntregaExpressa;
        produtoEncontrado.DataCadastro = produto.DataCadastro;
        produtoEncontrado.MarcaId = produto.MarcaId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _context.Produto.Remove(produtoEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Produto produto)
    {
        _context.Produto.Add(produto);
        _context.SaveChanges();
    }

    public Produto Obter(int id)
    {
        return _context.Produto.SingleOrDefault(item => item.ProdutoId == id);
    }

    public IList<Produto> ObterTodos()
    {
        return _context.Produto.ToList();
    }

    public IList<Marca> ObterTodasMarcas() => _context.Marca.ToList();

    public Marca ObterMarca(int id) => _context.Marca.SingleOrDefault(item => item.MarcaId == id);
}
