using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class LoadingScreen : MonoBehaviour
    {
        private int _loadingTime = 3;

        private void Start()
        {
            StartCoroutine(LoadingCoroutine());
        }

        private IEnumerator LoadingCoroutine()
        {
            yield return new WaitForSecondsRealtime(_loadingTime);

            SceneManager.LoadScene("MainMenu");
        }
    }
}