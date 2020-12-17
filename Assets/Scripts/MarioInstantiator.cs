using UnityEngine;

public class MarioInstantiator : MonoBehaviour
{
    [SerializeField] private Mario _template;

    public void Spawn() =>
        Instantiate(_template, transform.position, Quaternion.identity);
}
