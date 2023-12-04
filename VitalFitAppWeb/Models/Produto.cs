using System.ComponentModel.DataAnnotations;

namespace VitalFitAppWeb.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve ter entre 10 e 50 caracteres")]
        public string Nome { get; set; }
        public string NomeSlug => Nome.ToLower().Replace(" ", "-");

        [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
        [StringLength(100, MinimumLength = 50, ErrorMessage = "Campo 'Descrição' deve ter entre 50 e 100 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório.")]
        [Display(Name = "Caminho URL da imagem")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Campo 'Tipo de produto' obrigatório.")]
        public string ProdutoTipo { get; set; }

        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Preco { get; set; }

        [Display(Name = "Entrega Expressa")]
        public bool EntregaExpressa { get; set; }

        
        public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

        [Required(ErrorMessage = "Campo 'Dísponivel em' obrigatório.")]
        [Display(Name = "Disponível em")]
        [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
        [DataType("month")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Marca")]
        public int? MarcaId { get; set; }

    }
}
