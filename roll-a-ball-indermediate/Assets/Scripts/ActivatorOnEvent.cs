using System;
using System.Collections;
using UnityEngine;

public class ActivatorOnEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject _target = null;

    [SerializeField]
    private float _activeSeconds = 3f;

    [SerializeField]
    private EventBus _activator = null;

    private WaitForSeconds _waitForSeconds = null;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_activeSeconds);
        _activator.AddListener(Activate);
        _target.SetActive(false);
    }

    private void OnDestroy()
    {
        _activator.RemoveListener(Activate);
    }

    void Activate()
    {
        _target.SetActive(true);
        StartCoroutine(DelayedHideCoroutine());
    }

    IEnumerator DelayedHideCoroutine()
    {
        yield return _waitForSeconds;
        _target.SetActive(false);
    }
}