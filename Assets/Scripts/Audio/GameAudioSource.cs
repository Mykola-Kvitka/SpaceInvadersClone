using UnityEngine;

namespace Audio
{
    /// <summary>
    /// An audio source for the entire game
    /// </summary>
    public class GameAudioSource : MonoBehaviour
    {
        /// <summary>
        /// Awake is called before Start
        /// </summary>
        void Awake()
        {
            // initialize audio manager
            if (!AudioManager.Inizialized)
            {
                AudioSource audioSource = gameObject.AddComponent<AudioSource>();
                AudioManager.Initialize(audioSource);
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }
    }
}