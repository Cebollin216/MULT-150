using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator_Old : MonoBehaviour
{
    public GameObject lampPrefab;   // assign FR_StreetLamp
    public Transform spawnParent;   // assign Spawns
    public Vector3 lineStart = new Vector3(0f, 0f, 0f);
    public int count = 10;
    public float spacing = 3f;
    public bool alignAlongX = true;

    private readonly List<GameObject> spawned = new List<GameObject>();

    void Start()
    {
        // Spawn 10 lamps in a straight line
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = lineStart + (alignAlongX ? new Vector3(i * spacing, 0, 0)
                                                   : new Vector3(0, 0, i * spacing));
            spawned.Add(Instantiate(lampPrefab, pos, Quaternion.identity, spawnParent));
        }
    }

    void Update()
    {
        // B = spawn one more at mouse hit point (on Floor)
        if (Input.GetKeyDown(KeyCode.B))
        {
            Vector3 spawnPos = lineStart;
            if (Camera.main != null)
            {
                Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(r, out RaycastHit hit, 500f)) spawnPos = hit.point;
            }
            spawned.Add(Instantiate(lampPrefab, spawnPos, Quaternion.identity, spawnParent));
        }

        // Space = clear all spawned
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = spawned.Count - 1; i >= 0; i--)
                if (spawned[i] != null) Destroy(spawned[i]);
            spawned.Clear();
        }
    }
}
