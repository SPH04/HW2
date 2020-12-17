using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mario _mario;

    public void Spawn()
    {
        Instantiate(_mario, GetComponent<Transform>().position, Quaternion.identity);
    }
}
