using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    [SerializeField] private Transform _spawn;
    [SerializeField] private Spider _template;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[_spawn.childCount];
        for (int i = 0; i < _spawn.childCount; i++)
        {
            _spawnPoints[i] = _spawn.GetChild(i);
        }
        var createEnemy = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        var waitSecods = new WaitForSeconds(2);
            Debug.Log(_spawn.childCount);
        
        for (uint i = 0; i < uint.MaxValue; i++)
        {            
            var enemy = Instantiate(_template, _spawnPoints[Random.Range(0, _spawn.childCount - 1)]);

            yield return waitSecods;            
        }
    }




}
