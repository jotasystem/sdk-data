namespace JotaSystem.Sdk.Data.Models
{
    public class BrazilCityModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public MicrorregiaoInfo Microrregiao { get; set; } = default!;

        public class MicrorregiaoInfo
        {
            public int Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public MesorregiaoInfo Mesorregiao { get; set; } = default!;

            public class MesorregiaoInfo
            {
                public int Id { get; set; }
                public string Nome { get; set; } = string.Empty;
                public UFInfo UF { get; set; } = default!;

                public class UFInfo
                {
                    public int Id { get; set; }
                    public string Sigla { get; set; } = string.Empty;
                    public string Nome { get; set; } = string.Empty;
                    public RegiaoInfo Regiao { get; set; } = default!;

                    public class RegiaoInfo
                    {
                        public int Id { get; set; }
                        public string Sigla { get; set; } = string.Empty;
                        public string Nome { get; set; } = string.Empty;
                    }
                }
            }
        }
    }
}