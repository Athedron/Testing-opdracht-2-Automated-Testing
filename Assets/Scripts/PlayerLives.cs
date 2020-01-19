using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public static int lives;
    public Text liveCount;

    public GameObject uiObject;
    public GameObject playerCharacter;
    public GameObject levelObjects;

    bool isDead = false;

    void Start()
    {
        //uiObject.SetActive(false);
        lives = 3;
    }

    void Update()
    {
        liveCount.text = "Lives: " + lives;

        if (lives == 0)
        {
            isDead = true;
            Death();
        }

        
    }

    void Death()
    {
        if (isDead)
        {
            playerCharacter.SetActive(false);
            levelObjects.SetActive(false);
            uiObject.SetActive(true);
            lives = 3;
            isDead = false;
        }
       
    }
}
