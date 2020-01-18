using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int points;
    public Text pointsCounter;

    void Update()
    {
        pointsCounter.text = "Points: " + points/2;
    }
}
