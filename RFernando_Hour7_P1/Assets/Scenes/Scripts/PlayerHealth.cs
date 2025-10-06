using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        // 9) Two float variables
        float health;
        float poisonDamage;

        // 10) Assign values (note the f for floats)
        health = 1004f;
        poisonDamage = 125.5f;

        // 11) Log starting health
        Debug.Log(health);          // 1004

        // 13–26) Repeatedly subtract poisonDamage and log health
        health -= poisonDamage; Debug.Log(health);   // 878.5
        health -= poisonDamage; Debug.Log(health);   // 753
        health -= poisonDamage; Debug.Log(health);   // 627.5
        health -= poisonDamage; Debug.Log(health);   // 502
        health -= poisonDamage; Debug.Log(health);   // 376.5
        health -= poisonDamage; Debug.Log(health);   // 251
        health -= poisonDamage; Debug.Log(health);   // 125.5
        health -= poisonDamage; Debug.Log(health);   // 0

        // 27) Final message
        Debug.Log("Player has been unalived!");
    }
}
