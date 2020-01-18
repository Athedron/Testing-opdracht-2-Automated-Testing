using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Points.points++;
        Destroy(gameObject);
    }
}
