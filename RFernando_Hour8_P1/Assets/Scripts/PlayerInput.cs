using UnityEngine;
public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0) Debug.Log("Horizontal input: " + h);
        if (v != 0) Debug.Log("Vertical input: " + v);

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        if (mx != 0) Debug.Log("Mouse X: " + mx);
        if (my != 0) Debug.Log("Mouse Y: " + my);

        if (Input.GetKey(KeyCode.M)) Debug.Log("M key held");
        if (Input.GetKeyDown(KeyCode.O)) Debug.Log("O key pressed");
    }
}
