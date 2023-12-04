using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VitalFitAppWeb.Models;
using VitalFitAppWeb.Services;

namespace VitalFitAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private IProdutoService _service;
        public string NomeMarca { get; set; }
        public DetailsModel(IProdutoService service) 
        {
            _service = service;
        }
        public Produto Produto { get; private set; }
        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);
            if(Produto.MarcaId is not null)
            {
                NomeMarca = _service.ObterMarca(Produto.MarcaId.Value).Nome;
            }

            if(Produto == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
