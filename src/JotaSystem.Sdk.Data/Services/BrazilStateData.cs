using JotaSystem.Sdk.Data.Models;

namespace JotaSystem.Sdk.Data.Services
{
    public sealed class BrazilStateData : JsonDataServiceBase<BrazilStateModel>
    {
        protected override string ResourceFileName => "brazil-states.json";

        private static readonly BrazilStateData _instance = new();
        public static IReadOnlyList<BrazilStateModel> GetAll() => _instance.GetAllBase();
    }
}