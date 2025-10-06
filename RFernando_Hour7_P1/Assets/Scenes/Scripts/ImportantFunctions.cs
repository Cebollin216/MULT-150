using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    // Public variable (shows up in Inspector)
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        print("start runs before an object Updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update runs once per frame");
    }
}
