using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotationSpeed = Vector3.zero;

    private Transform _transform = null;

    private void Awake()
    {
        _transform = transform;
    }

    void Update()
    {
        _transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
}