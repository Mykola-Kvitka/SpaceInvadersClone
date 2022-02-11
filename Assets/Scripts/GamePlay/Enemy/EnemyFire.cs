using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GamePlay
{
    public class EnemyFire : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyBulletPrefab;
        [SerializeField] private int _changeToAttac = 50;
        [SerializeField] private float _fireDeley = 5;

        private void Start()
        {
            StartCoroutine(FireCoroutine());
        }
        
        private IEnumerator FireCoroutine()
        {
            while (true)
            {
                yield return new WaitForSecondsRealtime(_fireDeley);
                if (Random.Range(1, 100) <= _changeToAttac)
                {
                    var bullet = Instantiate(_enemyBulletPrefab);

                    bullet.transform.position = this.transform.position;
                }
            }
        }

    }
}