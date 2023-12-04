using Microsoft.EntityFrameworkCore.Migrations;
using VitalFitAppWeb.Models;

#nullable disable

namespace VitalFitAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new VitalFitDbContext();
            context.Marca.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicialMarca()
        {
            return new List<Marca>()
            {
                    new Marca() {Nome = "Ox",
                                Descricao="roupa"},
                    new Marca() {Nome = "Drx",
                                Descricao="roupa"},
                    new Marca() {Nome = "Rougue",
                                Descricao="equipamento"},
                    new Marca() {Nome = "Ultrawod",
                                Descricao="equipamentos"},
                    new Marca() {Nome = "Pood",
                                Descricao="acessorio"},
                    new Marca() {Nome = "Gladius",
                                Descricao="acessorio"},
            };
        }
    }
}
