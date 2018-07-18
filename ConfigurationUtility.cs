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
        }
    }
}