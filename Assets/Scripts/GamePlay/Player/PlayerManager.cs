using System;
using System.Collections;
using UnityEngine;

namespace GamePlay.Player
{
    /// <summary>
    /// The class for monitoring the player's health and related functionality also sends an event about the end of the game.
    /// </summary>
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private int _health = 3;
        [SerializeField] private int _deley = 0;

        private bool _isInvulnerable = false;

        public int GetHealth()
        {
            return _health;
        }

        private void Start()
        {
            throw new NotImplementedException();
        }

        private void TakeDamage()
        {
            if (_isInvulnerable)
            {
                _health -= 1;
                
                if(_health <= 0)
                    //GameOver;
                    
                StartCoroutine(InvulnerableCoroutine());
            }
        }
        
        private IEnumerator InvulnerableCoroutine()
        {
            _isInvulnerable = true;
            yield return new WaitForSecondsRealtime(_deley);
            _isInvulnerable = false;
        }
    }
}