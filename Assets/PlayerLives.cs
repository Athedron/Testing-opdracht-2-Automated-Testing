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

    void Start()
    {
        uiObject.SetActive(false);
        lives = 6;
    }

    void Update()
    {
        liveCount.text = "Lives: " + lives/2;
        Death();
    }

    void Death()
    {
        if (PlayerLives.lives <= 0)
        {
            playerCharacter.SetActive(false);
            levelObjects.SetActive(false);
            uiObject.SetActive(true);
        }
    }
}
