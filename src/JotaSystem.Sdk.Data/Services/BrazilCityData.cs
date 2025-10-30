using JotaSystem.Sdk.Data.Models;
namespace JotaSystem.Sdk.Data.Services
{
    public sealed class BrazilCityData : JsonDataServiceBase<BrazilCityModel>
    {
        protected override string ResourceFileName => "brazil-cities.json";

        private static readonly BrazilCityData _instance = new();
        public static  IReadOnlyList<BrazilCityModel> GetAll() => _instance.GetAllBase();
    }
}