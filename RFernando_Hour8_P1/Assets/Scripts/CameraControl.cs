using UnityEngine;
public class CameraControl : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        Vector3 move = new Vector3(mx, my, 0) * speed * Time.deltaTime;
        transform.Translate(move, Space.Self);
    }
}
