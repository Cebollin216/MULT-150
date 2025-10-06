using UnityEngine;

public class Addition: MonoBehaviour
{
    void Start()
    {
        // 1) Create 4 int variables
        int a;
        int b;
        int c;
        int sum;

        // 2) Assing values
        a = 2;
        b = 4;
        c = 8;

        // 3) Add them and put result in sum
        sum = a + b + c;

        // 4) Increment sum by 1
        sum++;

        // 5) Log the value
        Debug.Log(sum);  // Expect 15
    }
}