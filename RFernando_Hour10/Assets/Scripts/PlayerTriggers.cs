using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Pickup>(out var p))
        {
            GameManager.I.AddScore(p.value);
            Destroy(other.gameObject);
            return;
        }

        if (other.CompareTag("FallZone"))
        {
            GameManager.I.LoseLife();
            var rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1.2f, 0); // respawn
        }
    }
}
