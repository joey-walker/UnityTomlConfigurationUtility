using UnityEngine;

namespace ZCorp.ConfigurationUtilities
{
    public class Graphics
    {
        public Graphics()
        {
            AntiAliasing = QualitySettings.antiAliasing;
            AnisotropicFiltering = QualitySettings.anisotropicFiltering;
        }

        public int AntiAliasing { set; get; }
        public AnisotropicFiltering AnisotropicFiltering { set; get; }
    }
}