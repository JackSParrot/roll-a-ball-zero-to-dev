using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWithOffset : MonoBehaviour
{
    [SerializeField]
    private Transform _target = null;
    
    private Vector3 _offset = Vector3.zero;
    
    void Start()
    {
        _offset = transform.position - _target.position;
    }

    void LateUpdate()
    {
        transform.position = _target.position + _offset;
    }
}
