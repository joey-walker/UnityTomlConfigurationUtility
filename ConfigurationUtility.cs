using Nett;
using UnityEngine;

namespace ZCorp.ConfigurationUtilities
{
    public class ConfigurationUtility : MonoBehaviour
    {
        private void Start()
        {
            WriteDefaultConfig();
        }

        public void WriteDefaultConfig()
        {
            BaseConfiguration baseConfiguration = new BaseConfiguration();

            Toml.WriteFile(baseConfiguration, "./testConfiguration.toml");


            QualitySettings.antiAliasing = 2;

            baseConfiguration = new BaseConfiguration();

            Toml.WriteFile(baseConfiguration, "./testConfiguration.toml");

            var tomlTable = Toml.ReadFile("./testConfiguration.toml");

            baseConfiguration = null;
            
            baseConfiguration = new BaseConfiguration(tomlTable);

            var tomlTableCount = baseConfiguration.GetType();
        }
    }
}