using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;                          
    [SerializeField] float rotationSpeed;
    [SerializeField] float HP;
    // Update is called once per frame
    void Update()
    {
        // Checking the W, A, S and D keys' pressure
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(speed * Time.deltaTime, 0, 0);

        // Rotate when move mouse
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}
