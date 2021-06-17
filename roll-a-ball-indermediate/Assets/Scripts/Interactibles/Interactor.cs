using UnityEngine;

public class Interactor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out AInteractible interactible))
        {
            interactible.Interact();
        }
    }
}
