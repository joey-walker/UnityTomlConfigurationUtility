using UnityEngine;

namespace ZCorp.ConfigurationUtilities
{
    public class Graphics
    {

     /**
      * Todo: Shadow distance?
      */
        public Graphics()
        {
            AntiAliasing = QualitySettings.antiAliasing;
            AnisotropicFiltering = QualitySettings.anisotropicFiltering;
            DepthOfView = Camera.main.depth;
            FieldOfView = Camera.main.fieldOfView;
            LodBias = QualitySettings.lodBias;
            Resolution = Screen.currentResolution;
            ShadowQuality = QualitySettings.shadows;
            VSyncCount = QualitySettings.vSyncCount;
        }

        public int AntiAliasing { set; get; }

        /**
         * Anisotropic filtering mode.
         * Properties
         * Disable	Disable anisotropic filtering for all textures.
         * Enable	Enable anisotropic filtering, as set for each texture.
         * ForceEnable	Enable anisotropic filtering for all textures.
         * References:
         * https://docs.unity3d.com/ScriptReference/AnisotropicFiltering.html
         * https://docs.unity3d.com/ScriptReference/QualitySettings-anisotropicFiltering.html
         */
        public AnisotropicFiltering AnisotropicFiltering { set; get; }

        /**
         * Reference: https://docs.unity3d.com/ScriptReference/Camera-depth.html
         */
        public float DepthOfView { get; set; }

        /**
         * Reference: https://docs.unity3d.com/ScriptReference/Camera-fieldOfView.html
         */
        public float FieldOfView { get; set; }

        /**
         * Global multiplier for the LOD's switching distance.
         * A larger value leads to a longer view distance before a lower resolution LOD is picked.
         * Reference: https://docs.unity3d.com/ScriptReference/QualitySettings-lodBias.html
         *
         * TODO: lodbias vs https://docs.unity3d.com/ScriptReference/QualitySettings-maximumLODLevel.html
         */
        public float LodBias { get; set; }


        /**
         * Represents the display resolution.
         * Resolution structures are returned by Screen.resolutions property.
         * Reference: https://docs.unity3d.com/ScriptReference/Resolution.html
         */
        public Resolution Resolution { get; set; }


        /**
         * Reference: https://docs.unity3d.com/ScriptReference/ShadowQuality.html
         */
        public ShadowQuality ShadowQuality { get; set; }

        /**
         * "The number of VSyncs that should pass between each frame. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1, 2, 3, or 4."
         * Reference: https://docs.unity3d.com/ScriptReference/QualitySettings-vSyncCount.html
         */
        public int VSyncCount { set; get; }
    }
}