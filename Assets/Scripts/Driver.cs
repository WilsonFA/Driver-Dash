using UnityEngine;

public class Driver : MonoBehaviour
{

    float steerSpeed = 0.2f;
    float moveSpeed = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
