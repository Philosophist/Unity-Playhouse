using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePointEffector : MonoBehaviour
{
    public float myCharge = 10f;
    public PointEffector2D pointEffector;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Found Player");
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            if(playerController != null)
            {
                float value = myCharge * playerController.charge * pointEffector.forceMagnitude;
                pointEffector.forceMagnitude = value;
            }
        }
    }
}
