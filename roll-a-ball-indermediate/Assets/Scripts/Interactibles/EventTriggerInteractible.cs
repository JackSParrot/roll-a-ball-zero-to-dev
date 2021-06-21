using UnityEngine;

public class EventTriggerInteractible : AInteractible
{
    [SerializeField]
    private EventBus _eventBus = null;
    [SerializeField]
    private bool _destroyOnTrigger = false;

    public override void Interact()
    {
        _eventBus.Raise();
        if (_destroyOnTrigger)
        {
            Destroy(gameObject);
        }
    }
}