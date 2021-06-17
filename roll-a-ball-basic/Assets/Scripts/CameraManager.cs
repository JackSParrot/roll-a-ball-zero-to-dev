using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform Target = null;
    
    private Vector3   _offset    = Vector3.zero;
    private Transform _transform = null;
    
    private void Awake()
    {
        _transform = transform;
        _offset = _transform.position - Target.position;
    }

    private void Update()
    {
        _transform.position = Target.position + _offset;
    }
}
