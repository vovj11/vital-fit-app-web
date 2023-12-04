using VitalFitAppWeb.Models;

namespace VitalFitAppWeb.Services;

public interface IProdutoService
{
    IList<Produto> ObterTodos();
    Produto Obter(int id);
    void Incluir(Produto produto);
    void Alterar(Produto produto);
    void Excluir(int id);
    IList<Marca> ObterTodasMarcas();
    Marca ObterMarca(int id);
}
