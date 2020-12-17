using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Mario : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start() =>
        GetComponent<Animator>().SetBool("IsMovingRight", true);
    private void Update() =>
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    private void OnBecameInvisible() =>
        Destroy(gameObject);
}
