using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    private Spawner[] _spawners;

    private void Start()
    {
        _spawners = FindObjectsOfType<Spawner>();
        StartCoroutine(SpawnWithDelay());
    }   
    private void Update()
    {
        
    }
    private IEnumerator SpawnWithDelay()
    {
        while (true)
            for (int i = 0; i < _spawners.Length; i++)
            {
                _spawners[i].Spawn();
                yield return new WaitForSeconds(2);
            }
    }
}
