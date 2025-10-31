namespace JotaSystem.Sdk.Data.Models
{
    public class CountryModel
    {
        public Name Name { get; set; } = default!;
        public List<string> Tld { get; set; } = default!;
        public string Cca2 { get; set; } = string.Empty;
        public string Ccn3 { get; set; } = string.Empty;
        public string Cca3 { get; set; } = string.Empty;
        public string Cioc { get; set; } = string.Empty;
        public bool? Independent { get; set; }
        public string Status { get; set; } = string.Empty;
        public bool UnMember { get; set; }
        public string UnRegionalGroup { get; set; } = string.Empty;
        public Dictionary<string, Currency> Currencies { get; set; } = default!;
        public Idd Idd { get; set; } = default!;
        public List<string> Capital { get; set; } = default!;
        public List<string> AltSpellings { get; set; } = default!;
        public string Region { get; set; } = string.Empty;
        public string Subregion { get; set; } = string.Empty;
        public Dictionary<string, string> Languages { get; set; } = [];
        public Translations Translations { get; set; } = default!;
        public List<double> Latlng { get; set; } = default!;
        public bool Landlocked { get; set; }
        public List<string> Borders { get; set; } = default!;
        public decimal Area { get; set; }
        public string Flag { get; set; } = string.Empty;
        public string FlagUrl { get { return $"https://flagcdn.com/{Cca2.ToLower()}.svg"; } }
        public Demonyms Demonyms { get; set; } = default!;
    }

    public class Name
    {
        public string Common { get; set; } = string.Empty;
        public string Official { get; set; } = string.Empty;
        public Dictionary<string, Translation> Native { get; set; } = [];
    }

    public class Currency
    {
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;

    }

    public class Idd
    {
        public string Root { get; set; } = string.Empty;
        public List<string> Suffixes { get; set; } = default!;
    }

    public class Translations
    {
        public Translation? Ara { get; set; } = default!;
        public Translation Bre { get; set; } = default!;
        public Translation Ces { get; set; } = default!;
        public Translation Deu { get; set; } = default!;
        public Translation Est { get; set; } = default!;
        public Translation Fin { get; set; } = default!;
        public Translation Fra { get; set; } = default!;
        public Translation Hrv { get; set; } = default!;
        public Translation Hun { get; set; } = default!;
        public Translation Ita { get; set; } = default!;
        public Translation Jpn { get; set; } = default!;
        public Translation Kor { get; set; } = default!;
        public Translation Nld { get; set; } = default!;
        public Translation Per { get; set; } = default!;
        public Translation Pol { get; set; } = default!;
        public Translation Por { get; set; } = default!;
        public Translation Rus { get; set; } = default!;
        public Translation Slk { get; set; } = default!;
        public Translation Spa { get; set; } = default!;
        public Translation Srp { get; set; } = default!;
        public Translation Swe { get; set; } = default!;
        public Translation Tur { get; set; } = default!;
        public Translation Urd { get; set; } = default!;
        public Translation Zho { get; set; } = default!;
    }

    public class Translation
    {
        public string Official { get; set; } = string.Empty;
        public string Common { get; set; } = string.Empty;
    }


    public class Demonyms
    {
        public Demonym Eng { get; set; } = default!;
        public Demonym Fra { get; set; } = default!;
    }

    public class Demonym
    {
        public string F { get; set; } = string.Empty;
        public string M { get; set; } = string.Empty;
    }
}