using System;
using UnityEngine;

namespace GamePlay
{
    /// <summary>
    /// A class that controls the movement of a line of enemies
    /// </summary>
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField]private  float moveSpeed = 5;

        private bool _isMovingRight = true;
        private  Rigidbody2D Rd;
        
        private void Start()
        {
            Rd = GetComponent<Rigidbody2D> ();
            MoveRight();
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Side"))
            {
                if (_isMovingRight)
                {
                    _isMovingRight = false;
                    MoveLeft();
                }
                else
                {
                    _isMovingRight = true;
                    MoveRight();
                }
            }
        }

        private void MoveRight() 
        {
            Rd.velocity = new Vector2 (moveSpeed, 0);
        }

        private void MoveLeft() {
            Rd.velocity = new Vector2(-moveSpeed, 0);
        }

    }
}