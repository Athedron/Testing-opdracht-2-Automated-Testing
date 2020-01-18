using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerMovement player;
    public static int playerPosition = 1;
    public Vector3[] playerPositions;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        
        playerPositions = new Vector3[3];

        playerPositions[0] = new Vector3(-5f, 1f, 0f);
        playerPositions[1] = new Vector3(0f, 1f, 0f);
        playerPositions[2] = new Vector3(5f, 1f, 0f);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerPosition--;

            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerPosition++;

            if (playerPosition > 2)
            {
                playerPosition = 2;
            }
        }

        transform.position = playerPositions[playerPosition];
    }
}
