using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class AppConfigurationService
    {
        private static readonly Lazy<AppConfigurationService> _instance =
            new Lazy<AppConfigurationService>(() => new AppConfigurationService());

        private readonly Dictionary<string, string> _settings;

        private AppConfigurationService()
        {
            _settings = new Dictionary<string, string>()
            {
                { "AppName", "Release Manager API" },
                { "RetryCount", "3" }
            };
        }

        public static AppConfigurationService Instance => _instance.Value;

        public string GetSetting(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key]: null;
        }

    }
}
