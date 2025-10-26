using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Variable: holds player's HP amount
    int healthpoints = 3992;

    void Start()
    {
        // Call UsePotion() four times and store result each time
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Output result to Console
        Debug.Log("Final HP: " + healthpoints);
    }

    void Update()
    {
        // Nothing runs each frame here — only Start() runs once
    }

    // Function that adds 400 HP and returns new total
    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
