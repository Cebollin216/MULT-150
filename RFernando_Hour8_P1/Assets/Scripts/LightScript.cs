using UnityEngine;
[RequireComponent(typeof(Light))]
public class LightScript : MonoBehaviour
{
    Light bulb;
    void Awake() { bulb = GetComponent<Light>(); }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            bulb.enabled = !bulb.enabled;
    }
}
