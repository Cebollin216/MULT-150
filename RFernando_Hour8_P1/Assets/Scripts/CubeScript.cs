using UnityEngine;
public class CubeScript : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.05f, 0f, 0f);
        transform.Rotate(0f, 0f, 1f);
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
