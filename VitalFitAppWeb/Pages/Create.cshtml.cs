using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitalFitAppWeb.Models;
using VitalFitAppWeb.Services;

namespace VitalFitAppWeb.Pages
{
    public class CreateModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IProdutoService _service;
        public CreateModel(IProdutoService service) 
        {
            _service = service;
        }

        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(), 
                                                nameof(Marca.MarcaId), 
                                                nameof(Marca.Nome));
        }

        [BindProperty]
        public Produto Produto { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //inclusão
            _service.Incluir(Produto);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }
    }
}
