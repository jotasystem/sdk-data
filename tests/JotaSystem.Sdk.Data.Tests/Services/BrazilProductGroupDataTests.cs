using JotaSystem.Sdk.Data.Services;

namespace JotaSystem.Sdk.Data.Tests.Services
{
    public class BrazilProductGroupDataTests
    {
        [Fact]
        public void GetAllProductGroups_ShouldReturn_ValidBankList()
        {
            // Act
            var groups = BrazilProductGroupData.GetAll();

            // Assert
            Assert.NotNull(groups);
            Assert.NotEmpty(groups);
        }

        [Fact]
        public void GetAllProductGroups_ShouldReturn_SameInstanceOnMultipleCalls()
        {
            // Act
            var firstCall = BrazilProductGroupData.GetAll();
            var secondCall = BrazilProductGroupData.GetAll();

            // Assert
            Assert.Same(firstCall, secondCall); // garante que o cache interno é reutilizado
        }
    }
}