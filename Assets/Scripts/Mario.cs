using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Transform))]
public class Mario : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        GetComponent<Animator>().SetBool("IsMovingRight", true);
    }
    private void Update() => 
        _transform.Translate(Vector2.right * _speed * Time.deltaTime);
    private void OnBecameInvisible() => 
        Destroy(gameObject);
}
