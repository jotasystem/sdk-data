using JotaSystem.Sdk.Data.Services;

namespace JotaSystem.Sdk.Data.Tests.Services
{
    public class BrazilBankDataTests
    {
        [Fact]
        public void GetAllBanks_ShouldReturn_ValidBankList()
        {
            // Act
            var banks = BrazilBankData.GetAll();

            // Assert
            Assert.NotNull(banks);
            Assert.NotEmpty(banks);

            // Verifica alguns bancos conhecidos
            var bancoDoBrasil = banks.FirstOrDefault(b =>
                string.Equals(b.Nome, "Banco do Brasil S.A.", StringComparison.OrdinalIgnoreCase));
            var santander = banks.FirstOrDefault(b =>
                string.Equals(b.Nome, "Banco Santander S.A.", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(bancoDoBrasil);
            Assert.Equal(1, bancoDoBrasil!.Codigo);

            Assert.NotNull(santander);
            Assert.Equal(33, santander!.Codigo);
        }

        [Fact]
        public void GetAllBanks_ShouldReturn_SameInstanceOnMultipleCalls()
        {
            // Act
            var firstCall = BrazilBankData.GetAll();
            var secondCall = BrazilBankData.GetAll();

            // Assert
            Assert.Same(firstCall, secondCall); // garante que o cache interno é reutilizado
        }
    }
}