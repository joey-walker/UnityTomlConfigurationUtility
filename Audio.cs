using UnityEngine;

namespace ZCorp.ConfigurationUtilities
{
    public class Audio
    {
        public Audio()
        {
            SampleRate = AudioSettings.GetConfiguration().sampleRate;
            DspBufferSize = AudioSettings.GetConfiguration().dspBufferSize;
            AudioSpeakerMode = AudioSettings.GetConfiguration().speakerMode;
            Volume = AudioListener.volume;
        }

        public int SampleRate { get; set; }
        public int DspBufferSize { get; set; }
        public AudioSpeakerMode AudioSpeakerMode { get; set; }
        public float Volume { get; set; }
    }
}