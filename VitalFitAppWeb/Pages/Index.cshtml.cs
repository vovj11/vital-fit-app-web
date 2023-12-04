using Microsoft.AspNetCore.Mvc.RazorPages;
using VitalFitAppWeb.Models;
using VitalFitAppWeb.Services;

namespace VitalFitAppWeb.Pages;

public class IndexModel : PageModel
{
    private IProdutoService _service;
    public IndexModel(IProdutoService service)
    {
        _service = service;
    }
    public IList<Produto> ListaProduto { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = "Página Inicial";

        ListaProduto = _service.ObterTodos();

    }
}
