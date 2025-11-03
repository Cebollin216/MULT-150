using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    public float mouseRotateSpeed = 120f;

    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(-dirY * mouseRotateSpeed * Time.deltaTime,
                         dirX * mouseRotateSpeed * Time.deltaTime, 0);
        CheckForRaycastHit();
    }

    void CheckForRaycastHit()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 100f))
        {
            Debug.Log(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}
