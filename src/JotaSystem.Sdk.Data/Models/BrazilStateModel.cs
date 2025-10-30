namespace JotaSystem.Sdk.Data.Models
{
    public class BrazilStateModel
    {
        public int Id { get; set; }
        public string Sigla { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public RegiaoInfo Regiao { get; set; } = default!;

        public class RegiaoInfo
        {
            public int Id { get; set; }
            public string Sigla { get; set; } = default!;
            public string Nome { get; set; } = default!;
            public string Pais { get; set; } = default!;
        }
    }
}