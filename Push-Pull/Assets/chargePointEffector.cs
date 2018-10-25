using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public float forceMagnitude = 10f;
public float charge = -1f;
public float distanceFactor = 0.1f;
public float drag = 0;
public float angularDrag = 10f;

public class chargePointEffector : MonoBehaviour {


    void FixedUpdate()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Moveable"))
        {
            Debug.Log("Touched a Moveable");
            private float distance = 1;
            Vector2 direction = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(forceMagnitude * direction * charge * collision.values.charge / (distanceFactor * distance) ^ 2);
        }
    }
    
}
