using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public UnityEvent onTriggerActivated;

    private void OnTriggerEnter(Collider other)
    {
        // Trigger the event when anything enters the trigger zone
        onTriggerActivated.Invoke();
    }
}
