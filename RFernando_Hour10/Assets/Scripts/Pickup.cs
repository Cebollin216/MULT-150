using UnityEngine;
public class Pickup : MonoBehaviour
{
    public int value = 1;
    public float rotateSpeed = 90f;
    void Update() => transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
}
