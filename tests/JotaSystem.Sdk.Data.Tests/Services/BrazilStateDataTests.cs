using JotaSystem.Sdk.Data.Services;

namespace JotaSystem.Sdk.Data.Tests.Services
{
    public class BrazilStateDataTests
    {
        [Fact]
        public void GetAll_ShouldReturnStates()
        {
            // Act
            var states = BrazilStateData.GetAll();

            // Assert
            Assert.NotNull(states);                 // lista não é null
            Assert.True(states.Count > 0);         // contém registros
            Assert.Contains(states, s => s.Sigla == "SP");  // verifica um estado conhecido
            Assert.All(states, s => Assert.False(string.IsNullOrWhiteSpace(s.Nome)));  // todos têm nome
            Assert.All(states, s => Assert.NotNull(s.Regiao));  // todos têm região
        }

        [Fact]
        public void GetAll_ShouldReturnCachedInstance()
        {
            // Act
            var firstCall = BrazilStateData.GetAll();
            var secondCall = BrazilStateData.GetAll();

            // Assert
            Assert.Same(firstCall, secondCall);  // mesma instância (cache)
        }

        [Fact]
        public void GetAll_ShouldContainCorrectRegionData()
        {
            // Act
            var states = BrazilStateData.GetAll();
            var sp = states.First(s => s.Sigla == "SP");

            // Assert
            Assert.Equal("Sudeste", sp.Regiao.Nome);
            Assert.Equal("SE", sp.Regiao.Sigla);
            Assert.Equal("Brasil", sp.Regiao.Pais);
        }

        [Fact]
        public void GetAll_ShouldThrowFileNotFound_WhenResourceMissing()
        {
            // Arrange
            var assembly = typeof(BrazilStateData).Assembly;
            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(x => x.EndsWith("nonexistent.json", System.StringComparison.OrdinalIgnoreCase));

            // Act & Assert
            Assert.Null(resourceName); // recurso inexistente retorna null
        }
    }
}
