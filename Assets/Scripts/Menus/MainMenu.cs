using Audio;
using Audio.AudioEnum;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class MainMenu : MonoBehaviour
    { 
        private void Start()
        {
            AudioManager.Play(AudioClipName.MainMenuTheam);
        }
    
        public void HandlePlayButtonOnClickEvent()
        {
            SceneManager.LoadScene("Game");
        }
    
        public void HandleSettingButtonOnClickEvent()
        {
            SceneManager.LoadScene("Settings");
        }  

        public void HandleQuitButtonOnClickEvent()
        {
            Application.Quit();
        }
    }
}
