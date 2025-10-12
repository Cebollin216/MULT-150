using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int daysInMyBirthMonth = 28; // February has 28 days
        int myBirthdayDay = 16;         // your birthday day

        // Loop through every day of the month
        for (int day = 1; day <= daysInMyBirthMonth; day++)
        {
            if (day == myBirthdayDay)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}