using System;
using Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menus
{
    /// <summary>
    /// Class for working with the event of pressing buttons in the settings menu.
    /// </summary>
    public class SettingsMenu : MonoBehaviour
    {
        [SerializeField] private Button _soundButton;
        
        private bool _IsMusicPlaying = true;

        /// <summary>
        /// Method to Adjust Music Volume.
        /// </summary>
        public void HandleVolumeOnClickEvent()
        {
            if (_IsMusicPlaying)
            {
                _IsMusicPlaying = false;
                
                AudioManager.SetVolume(0);
                _soundButton.GetComponentInChildren<Text>().text = "ЗВУК               " + "Выкл";
            }
            else
            {
                _IsMusicPlaying = true;

                AudioManager.SetVolume(1);
                _soundButton.GetComponentInChildren<Text>().text = "ЗВУК               " + "ВКЛ";
            }
        }

        /// <summary>
        /// Method for event handling Pressing the button exits the setting menu.
        /// </summary>
        public void HandleBackOnClickEvent()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}