using UnityEngine;

public class Evens : MonoBehaviour
{
    void Start()
    {
        //Loop from 22 to 100, going up by 2 each time
        for (int n = 22; n <= 100; n += 2)
        {
            Debug.Log(n);
        }
    }
}