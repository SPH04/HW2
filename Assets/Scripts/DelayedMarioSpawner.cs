using System.Collections;
using UnityEngine;

public class DelayedMarioSpawner : MonoBehaviour
{
    [SerializeField] private float _delayTime;

    private MarioInstantiator[] _instantiators;

    private void Start()
    {
        _instantiators = FindObjectsOfType<MarioInstantiator>();
        StartCoroutine(SpawnWithDelay()); 
    }
    private IEnumerator SpawnWithDelay()
    {
        while (true)
        {
            foreach (MarioInstantiator instantiator in _instantiators)
            {
                instantiator.Spawn();
                yield return new WaitForSeconds(_delayTime);
            }
        }
    }
}
