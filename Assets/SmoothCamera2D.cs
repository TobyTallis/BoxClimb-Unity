using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera2D : MonoBehaviour
{

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 destination = new Vector3(transform.position.x, target.transform.position.y, -10);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }
}
