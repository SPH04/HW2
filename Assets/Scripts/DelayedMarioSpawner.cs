using System.Collections;
using UnityEngine;

public class DelayedMarioSpawner : MonoBehaviour
{
    [SerializeField] private float _delayTime;

    private MarioInstantiator[] _spawners;

    private void Start()
    {
        _spawners = FindObjectsOfType<MarioInstantiator>();
        StartCoroutine(SpawnWithDelay());
    }
    private IEnumerator SpawnWithDelay()
    {
        while (true)
        {
            foreach (MarioInstantiator instantiator in _spawners)
            {
                instantiator.Spawn();
                yield return new WaitForSeconds(_delayTime);
            }
        }
    }
}
