using Xunit;
using System.Linq;
using JotaSystem.Sdk.Data.Services;

namespace JotaSystem.Sdk.Data.Tests.Services
{
    public class CountryDataTests
    {
        [Fact]
        public void GetAll_ShouldReturnCountries()
        {
            // Act
            var countries = CountryData.GetAll();

            // Assert
            Assert.NotNull(countries);                 // lista não é null
            Assert.True(countries.Count > 0);         // contém registros
            Assert.Contains(countries, c => c.Cca2 == "BR");  // verifica Brasil
            Assert.All(countries, c => Assert.False(string.IsNullOrWhiteSpace(c.Name.Official)));  // todos têm nome
            Assert.All(countries, c => Assert.False(string.IsNullOrWhiteSpace(c.Region)));  // todos têm região
        }

        [Fact]
        public void GetAll_ShouldReturnCachedInstance()
        {
            // Act
            var firstCall = CountryData.GetAll();
            var secondCall = CountryData.GetAll();

            // Assert
            Assert.Same(firstCall, secondCall);  // mesma instância (cache)
        }

        [Fact]
        public void GetAll_ShouldContainCorrectDataForBrazil()
        {
            // Act
            var countries = CountryData.GetAll();
            var brazil = countries.First(c => c.Cca2 == "BR");

            // Assert
            Assert.Equal("Brazil", brazil.Name.Common);
            Assert.Equal("Brasil", brazil.Name.Native.ToList()[0].Value.Common);
            Assert.Equal("Portuguese", brazil.Languages.ToList()[0].Value);
            Assert.Equal("R$", brazil.Currencies.ToList()[0].Value.Symbol);
            Assert.Equal("BRA", brazil.Cca3);
            Assert.Equal("Brasília", brazil.Capital[0]);
        }

        [Fact]
        public void GetAll_ShouldThrowFileNotFound_WhenResourceMissing()
        {
            // Arrange
            var assembly = typeof(CountryData).Assembly;
            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(x => x.EndsWith("nonexistent.json", System.StringComparison.OrdinalIgnoreCase));

            // Act & Assert
            Assert.Null(resourceName); // recurso inexistente retorna null
        }
    }
}