using System;
using System.Collections;
using UnityEngine;

namespace GamePlay.Player
{
    /// <summary>
    /// The class that is responsible for controlling the player's shooting
    /// </summary>
    public class PlayerFire : MonoBehaviour
    {
        [SerializeField]private float _fireDeley = 1;
        [SerializeField]private GameObject _bulletPrefab;
        [SerializeField]private float _bulletSpeed = 2;

        private void Start()
        {
            StartCoroutine(FireCoroutine());
        }
        
        private IEnumerator FireCoroutine()
        {
            while (true)
            {
                yield return new WaitForSecondsRealtime(_fireDeley);
            
                var bullet = Instantiate(_bulletPrefab);
            
                bullet.transform.position = this.transform.position;

                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0,_bulletSpeed);

            }
        }
    }
}