using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform _spawn;
    [SerializeField] private Spider _template;
    [SerializeField] private float _spwanTimer;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[_spawn.childCount];
        for (int i = 0; i < _spawn.childCount; i++)
        {
            _spawnPoints[i] = _spawn.GetChild(i);
        }
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        var waitSecods = new WaitForSeconds(_spwanTimer);
            Debug.Log(_spawn.childCount);
        
        for (uint i = 0; i < uint.MaxValue; i++)
        {            
            Instantiate(_template, _spawnPoints[Random.Range(0, _spawn.childCount - 1)]);

            yield return waitSecods;            
        }
    }
}
