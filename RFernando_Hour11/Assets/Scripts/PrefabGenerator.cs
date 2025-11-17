using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject lampPrefab;   // Assign StreetLamp
    public Vector3 lineStart = new Vector3(-20f, 0f, 0f);
    public int count = 10;
    public float spacing = 5f;
    public bool alignAlongX = true;

    private readonly List<GameObject> spawned = new List<GameObject>();

    void Start()
    {
        // Spawn lamps on Start
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = lineStart + (alignAlongX ? new Vector3(i * spacing, 0, 0)
                                                   : new Vector3(0, 0, i * spacing));

            spawned.Add(Instantiate(lampPrefab, pos, Quaternion.identity));
        }
    }

    void Update()
    {
        // Add a new lamp with B
        if (Input.GetKeyDown(KeyCode.B))
        {
            Vector3 pos = lineStart +
                          (alignAlongX ? new Vector3(spawned.Count * spacing, 0, 0)
                                       : new Vector3(0, 0, spawned.Count * spacing));

            spawned.Add(Instantiate(lampPrefab, pos, Quaternion.identity));
        }

        // Remove last lamp with Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawned.Count > 0)
            {
                GameObject last = spawned[spawned.Count - 1];
                Destroy(last);
                spawned.RemoveAt(spawned.Count - 1);
            }
        }
    }
}
