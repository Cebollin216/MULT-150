using UnityEngine;

public class Hazard : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // When the player hits the hazard
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hazard hit! Losing life...");
            GameManager.I.LoseLife(); // Call the function in GameManager
        }
    }
}
