using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.2f;
    [SerializeField] float moveSpeed = 0.02f;


    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Forward");
        }
        
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Backward");
        }

        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("Right");
        }

        else if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("Left");
        }

        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
