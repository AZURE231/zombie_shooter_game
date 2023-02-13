using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMovement : MonoBehaviour
{
    [SerializeField] float rotateAmount = 100f;
    [SerializeField] CinemachineVirtualCamera playerCamera;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotateAmount * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotateAmount * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //playerCamera.transform.rotation = Quaternion.Euler(xRotation, 0f, 0f);
        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //playerBody.Rotate(Vector3.up * mouseX);
        //playerCamera.transform.Rotate(Vector3.up * mouseX);
    }
}
