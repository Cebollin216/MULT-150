using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        // Match the assigment's first two prints:
        double health = 1004;       // prints: 1004
        Debug.Log(health);

        double poisonDamage = 125.5; // then: 878.5
        health -= poisonDamage;
        Debug.Log(health);

        // Keep damaging while alive:
        while (health > 0)
        {
            health -= poisonDamage;
            if (health < 0) health = 0; // clamp so final print i exactly 0
            Debug.Log(health);
        }

        // After loop:
        if (health <= 0)
        {
            Debug.Log("Player has been unalived!");
        }
    }
}