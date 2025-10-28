using System;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float delayPickup = 0f;
    bool hasPackage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up Package!");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delayPickup);
        }

        if (collision.CompareTag("Customer") && hasPackage == true)
        {
            Debug.Log("Delivered Package!");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }

}
