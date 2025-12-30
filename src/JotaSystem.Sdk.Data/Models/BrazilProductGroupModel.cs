namespace JotaSystem.Sdk.Data.Models
{
    public class BrazilProductGroupModel
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string NomeCompleto { get; set; } = string.Empty;
        public List<BrazilProductGroupModel>? Grupos { get; set; }
    }
}