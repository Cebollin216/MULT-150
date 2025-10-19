using UnityEngine;
public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball() { int h = 100; return h - 10; }
    int TakeDamageFromFireball(int dmg) { int h = 100; return h - dmg; }
    int TakeDamageFromFireball(int dmg, int armor)
    { int h = 100; return h - (dmg - armor); }

    void Start()
    {
        int x = TakeDamageFromFireball();
        Debug.Log("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        Debug.Log("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z);
    }
}
