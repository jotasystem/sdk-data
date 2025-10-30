using JotaSystem.Sdk.Data.Models;

namespace JotaSystem.Sdk.Data.Services
{
    public sealed class BrazilBankData : JsonDataServiceBase<BrazilBankModel>
    {
        protected override string ResourceFileName => "brazil-banks.json";

        private static readonly BrazilBankData _instance = new();
        public static IReadOnlyList<BrazilBankModel> GetAll() => _instance.GetAllBase();
    }
}