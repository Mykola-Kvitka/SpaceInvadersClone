using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class PauseMenu : MonoBehaviour
    {
        //Prefab of PauseMenu
        [SerializeField] private GameObject pauseMenuUi;
        
        // Start is called before the first frame update
        private void Start()
        {
            Time.timeScale = 0;
        }

        public void HandleMainButtonOnClickEvent()
        {
            Time.timeScale = 1;
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");
        }
        public void HandleResumeButtonOnClickEvent()
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}