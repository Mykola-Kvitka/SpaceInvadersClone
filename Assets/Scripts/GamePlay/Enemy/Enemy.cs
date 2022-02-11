using System;
using UnityEngine;

namespace GamePlay
{
    /// <summary>
    /// A class that describes the essence of the enemy, how many points are given for it and is waiting for the collision event with the player's bullet
    /// </summary>
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int _points = 20;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("PlayerBullet"))
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}