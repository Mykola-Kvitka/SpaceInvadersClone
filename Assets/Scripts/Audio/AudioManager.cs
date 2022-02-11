using System.Collections.Generic;
using Audio.AudioEnum;
using UnityEngine;

namespace Audio
{
    public static class AudioManager
    {
        static bool inizialized = false;
        static AudioSource audioSource;
        
        static Dictionary<AudioClipName, AudioClip> audioClips =
            new Dictionary<AudioClipName, AudioClip>();

        /// <summary>
        /// Initializes the audio manager
        /// </summary>
        /// <param name="source">audio source</param>
        public static bool Inizialized { get { return inizialized; } }
        
        public static void Initialize(AudioSource source)
        {
            inizialized = true;
            audioSource = source;

            audioClips.Add(AudioClipName.MainMenuTheam,
                Resources.Load<AudioClip>("MainMusic"));
        }

        /// <summary>
        /// Plays the audio clip with the given name
        /// </summary>
        /// <param name="name">name of the audio clip to play</param>
        public static void Play(AudioClipName name)
        {
            audioSource.PlayOneShot(audioClips[name]);
            audioSource.PlayScheduled(AudioSettings.dspTime + audioClips[name].length);
        }

        public static void SetVolume(float volume)
        {
            audioSource.volume = volume;
        }
    }
}