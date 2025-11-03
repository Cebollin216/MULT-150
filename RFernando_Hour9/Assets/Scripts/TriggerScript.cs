using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
        => Debug.Log(other.name + " entered the trigger");
    void OnTriggerStay(Collider other)
        => Debug.Log(other.name + " is still inside");
    void OnTriggerExit(Collider other)
        => Debug.Log(other.name + " left the trigger");
}
