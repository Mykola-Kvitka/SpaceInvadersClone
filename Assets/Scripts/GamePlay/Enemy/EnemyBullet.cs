using System;
using UnityEngine;

namespace GamePlay
{
    public class EnemyBullet : Bullet
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player")) ;
                Debug.Log("GameOver");
        }
    }
}