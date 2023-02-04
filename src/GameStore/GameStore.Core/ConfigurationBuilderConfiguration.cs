using Microsoft.Extensions.Configuration;

namespace GameStore.Core
{
    public class ConfigurationBuilderConfiguration
    {
        public IConfiguration GetConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile("appSettings.Development.json", optional: true, reloadOnChange: true);

            return configurationBuilder.Build();
        }
    }
}
