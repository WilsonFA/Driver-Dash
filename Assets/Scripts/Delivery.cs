using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    //if(Car collider package)
    //then package destroy yourself and show message.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up Package!");
        }
    }
}
