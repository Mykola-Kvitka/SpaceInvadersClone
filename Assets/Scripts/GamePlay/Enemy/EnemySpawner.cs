using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GamePlay
{
    /// <summary>
    /// Spawn enemies and move them into them after a certain amount of time.
    /// </summary>
    public class EnemySpawner : MonoBehaviour
    {
        // TODO: add scriptableObj
        [SerializeField] private GameObject _spawnPoint;
        [SerializeField] private GameObject _enemyPrefab;
        [SerializeField] private Transform _gameOverPosition;
        [SerializeField] private List<GameObject> _enemyLines;
        [SerializeField] private float _spawnDeley = 10;
        [SerializeField] private float _space = 0.5f;

        private void Start()
        {
            SpawnEnemyLine();
            SpawnEnemyLine();
            SpawnEnemyLine();
            SpawnEnemyLine();

            StartCoroutine(SpawnCoroutine());
        }

        private IEnumerator SpawnCoroutine()
        {
            while (_enemyLines.First().transform.position.y > _gameOverPosition.position.y)
            {
                yield return new WaitForSecondsRealtime(_spawnDeley);

                SpawnEnemyLine();
            }

            //gameover event
        }

        private void SpawnEnemyLine()
        {
            MoveDown();

            var line = Instantiate(_enemyPrefab);

            line.transform.position = _spawnPoint.transform.position;

            _enemyLines.Add(line);
        }

        private void MoveDown()
        {
            foreach (var line in _enemyLines)
            {
                if (line.transform.hierarchyCount != 0)
                {
                    var transformPosition = line.transform.position;
                    transformPosition.y = transformPosition.y - _space;
                    line.transform.position = transformPosition;
                }
            }
        }
    }
}