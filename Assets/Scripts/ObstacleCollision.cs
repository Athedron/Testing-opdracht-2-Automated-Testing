using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    int countDownStartValue = 3;
    bool invincibility;

    
    void Start()
    {
        invincibility = false;
    }
   

    private void OnTriggerEnter(Collider other)
    {
        PlayerLives.lives--;

        if (invincibility == false)
        {
            invincibility = true;
            InvincibilityCountDownTimer();
        }
    }

    void InvincibilityCountDownTimer()
    {
        if (countDownStartValue > 0)
        {
            countDownStartValue--;
            Invoke("InvincibilityCountDownTimer", 1.0f);
        }
        else if (invincibility == true)
        {
            invincibility = false;
        }
    }

    
}
