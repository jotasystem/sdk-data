using JotaSystem.Sdk.Data.Models;

namespace JotaSystem.Sdk.Data.Services
{
    public sealed class BrazilProductGroupData : JsonDataServiceBase<BrazilProductGroupModel>
    {
        protected override string ResourceFileName => "brazil-product-groups.json";

        private static readonly BrazilProductGroupData _instance = new();
        public static IReadOnlyList<BrazilProductGroupModel> GetAll() => _instance.GetAllBase();
    }
}