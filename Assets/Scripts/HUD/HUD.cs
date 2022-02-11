using System;
using GamePlay.Player;
using UnityEngine;
using UnityEngine.UI;

namespace HUD
{
    public class HUD : MonoBehaviour
    {
        public int score;
        public PlayerManager PlayerManager;
        public Text scoreText;
        public Text healthText;

        private void Update()
        {
            scoreText.text = "Score : " + score.ToString();
            healthText.text = "Health : " + PlayerManager.GetHealth();
        }
    }
}