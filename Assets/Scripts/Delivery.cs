using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up Package!");
            hasPackage = true;
        }

        if (collision.CompareTag("Customer") && hasPackage == true)
        {
            Debug.Log("Delivered Package!");
            hasPackage = false;
        }
    }

}
