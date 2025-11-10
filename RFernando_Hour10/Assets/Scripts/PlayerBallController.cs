using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerBallController : MonoBehaviour
{
    public float moveForce = 12f;
    Rigidbody rb;

    void Awake() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(h, 0, v) * moveForce;
        rb.AddForce(force);
    }
}
