using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public static float levelMovementSpeed = 30f;
    public Vector3 levelDirection = new Vector3(0f, 0f, levelMovementSpeed);


    void Update()
    {
        transform.Translate(levelDirection * Time.deltaTime);
    }
}
