using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CameraController : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public float multiplier;
    public Vector3 offset;

    public Transform target;
    public Transform body;
    public Transform mainCam;

    float xRotation;
    float yRotation;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

        yRotation += mouseX * multiplier;

        xRotation -= mouseY * multiplier;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        mainCam.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        body.rotation = Quaternion.Euler(0, yRotation, 0);
        mainCam.transform.position = target.transform.position + offset;

       
    }
    
  
}