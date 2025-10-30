using System.Reflection;
using System.Text.Json;

namespace JotaSystem.Sdk.Data
{
    public abstract class JsonDataServiceBase<T>
    {
        private static IReadOnlyList<T>? _cache;
        private static readonly object _lock = new();

        protected abstract string ResourceFileName { get; }

        public IReadOnlyList<T> GetAllBase()
        {
            if (_cache != null) return _cache;

            lock (_lock)
            {
                if (_cache != null) return _cache;

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = assembly
                    .GetManifestResourceNames()
                    .FirstOrDefault(x => x.EndsWith(ResourceFileName, StringComparison.OrdinalIgnoreCase))
                    ?? throw new FileNotFoundException($"Arquivo {ResourceFileName} não encontrado no assembly {assembly.FullName}.");

                using var stream = assembly.GetManifestResourceStream(resourceName)!;
                using var reader = new StreamReader(stream);
                var json = reader.ReadToEnd();

                _cache = JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? [];

                return _cache;
            }
        }
    }
}