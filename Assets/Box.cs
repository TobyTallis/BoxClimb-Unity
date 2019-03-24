using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IPooledObject
{

    private float velocityXMin = -1f;
    private float velocityXMax = 1f;
    private float velocityYMin = -2f;
    private float velocityYMax = 0f;
    private float angularVelocityMin = -5f;
    private float angularVelocityMax = 5f;

    public void OnObjectSpawn()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(Random.Range(velocityXMin, velocityXMax), Random.Range(velocityYMin, velocityYMax));
        rb2D.angularVelocity = Random.Range(angularVelocityMin, angularVelocityMax);
        Debug.Log("HITHTEHREH");
    }
}
