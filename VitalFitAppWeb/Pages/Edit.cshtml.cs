using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using VitalFitAppWeb.Models;
using VitalFitAppWeb.Services;

namespace VitalFitAppWeb.Pages
{
    public class EditModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IProdutoService _service;
        public EditModel(IProdutoService service)
        {
            _service = service;
        }
        [BindProperty]
        public Produto Produto { get; set; }
        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                                nameof(Marca.MarcaId),
                                                nameof(Marca.Nome));

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!double.TryParse(Request.Form["Produto.Preco"], NumberStyles.Any, CultureInfo.InvariantCulture, out double preco))
            {
                ModelState.AddModelError("Produto.Preco", "Formato inv�lido para o campo de pre�o.");
                return Page();
            }

            Produto.Preco = preco;

            // Edi��o
            _service.Alterar(Produto);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            //Exclus�o
            _service.Excluir(Produto.ProdutoId);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }
    }
}
