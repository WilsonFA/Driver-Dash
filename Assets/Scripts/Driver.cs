using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float currentSpeed = 6f;
    [SerializeField] float steerSpeed = 160f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regularSpeed = 6f;
    [SerializeField] TMP_Text boostText;
    bool hasBoost;

    void Start()
    {
        boostText.gameObject.SetActive(false);
    }
    void Update()
    {
        float move = 0f;
        float steer = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;

            if (Keyboard.current.dKey.isPressed)
            {
                steer = -1f;
            }

            else if (Keyboard.current.aKey.isPressed)
            {
                steer = 1f;
            }
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;

            if (Keyboard.current.dKey.isPressed)
            {
                steer = 1f;
            }

            else if (Keyboard.current.aKey.isPressed)
            {
                steer = -1f;
            }
        }

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost") && !hasBoost)
        {
            currentSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            Debug.Log("Boost Activated!");
            hasBoost = true;
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        currentSpeed = regularSpeed;
        boostText.gameObject.SetActive(false);
        hasBoost = false;
    }
}
