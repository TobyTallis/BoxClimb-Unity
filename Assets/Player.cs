using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float forceMagnitude = 3f;
    public float maxForceRadius = 2f;
    public float minForceRadius = 0.5f;
    private Vector2 mousePress;
    private Rigidbody2D rb2D;
    private bool applyImpulse = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        applyImpulse = Input.GetMouseButtonDown(0);
    }

    private void FixedUpdate()
    {
        if (applyImpulse)
        {
            mousePress = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 forceVector = -mousePress;
            float sm = forceVector.sqrMagnitude;
            forceVector = sm > maxForceRadius * maxForceRadius ? maxForceRadius * forceVector.normalized : sm < minForceRadius * minForceRadius ? minForceRadius * forceVector.normalized : forceVector;
            rb2D.AddForce(forceVector * forceMagnitude, ForceMode2D.Impulse);
            applyImpulse = false;
        }

        if (transform.position.y > 0f)
        {
            transform.position = new Vector2(transform.position.x, 0f);
        }
    }
}
