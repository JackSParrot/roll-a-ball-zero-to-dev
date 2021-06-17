using UnityEngine;

public class PickupController : MonoBehaviour
{
    public Vector3 Speed = Vector3.zero;
    
    void Update()
    {
        transform.Rotate(Speed * Time.deltaTime);
    }
}
