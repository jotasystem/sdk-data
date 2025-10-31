using JotaSystem.Sdk.Data.Models;

namespace JotaSystem.Sdk.Data.Services
{
    public sealed class CountryData : JsonDataServiceBase<CountryModel>
    {
        protected override string ResourceFileName => "countries.json";

        private static readonly CountryData _instance = new();
        public static IReadOnlyList<CountryModel> GetAll() => _instance.GetAllBase();
    }
}