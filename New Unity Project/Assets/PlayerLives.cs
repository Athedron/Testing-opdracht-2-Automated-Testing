using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public static int lives;
    public Text liveCount;


    void Start()
    {
        lives = 6;
    }

    void Update()
    {
        liveCount.text = "Lives: " + lives/2;
    }
}
