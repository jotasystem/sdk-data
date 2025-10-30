using JotaSystem.Sdk.Data.Services;

namespace JotaSystem.Sdk.Data.Tests.Services
{
    public class BrazilCityDataTests
    {
        [Fact]
        public void GetAllCities_ShouldReturn_ValidCityList()
        {
            // Act
            var cities = BrazilCityData.GetAll();

            // Assert
            Assert.NotNull(cities);
            Assert.NotEmpty(cities);

            // Verifica uma cidade conhecida
            var saoPaulo = cities.FirstOrDefault(c =>
                string.Equals(c.Nome, "São Paulo", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(saoPaulo);
            Assert.NotNull(saoPaulo!.Microrregiao);
            Assert.NotNull(saoPaulo.Microrregiao.Mesorregiao);
            Assert.NotNull(saoPaulo.Microrregiao.Mesorregiao.UF);

            Assert.Equal("SP", saoPaulo.Microrregiao.Mesorregiao.UF.Sigla);

            var regiao = saoPaulo.Microrregiao.Mesorregiao.UF.Regiao;
            Assert.NotNull(regiao);
            Assert.Equal("Sudeste", regiao.Nome);
        }

        [Fact]
        public void GetAllCities_ShouldReturn_SameInstanceOnMultipleCalls()
        {
            // Act
            var firstCall = BrazilCityData.GetAll();
            var secondCall = BrazilCityData.GetAll();

            // Assert
            Assert.Same(firstCall, secondCall); // garante que usa o mesmo cache interno
        }
    }
}
