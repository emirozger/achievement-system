using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveX, moveZ;
    [SerializeField] private float moveSpeed;
    private Rigidbody playerRb;
    private Transform mainCamTransform;
    public GameObject achievementPanel;
    public static PlayerController Instance;

    private void Awake()
    {
        playerRb = this.GetComponent<Rigidbody>(); 
        mainCamTransform = Camera.main.transform;
    }
    void Update()
    {
        GetInput();
        GetMovement();
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            achievementPanel.transform.DOMoveY(0.0f, 0.5f).SetEase(Ease.InBack);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            achievementPanel.transform.DOMoveY(-476.0f, 0.5f).SetEase(Ease.InBack);
        }
    }
    private void GetInput()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
    }

    private void GetMovement()
    {
        Vector3 cameraForward = mainCamTransform.forward;
        Vector3 cameraRight = mainCamTransform.right;
        cameraForward.y = 0;
        cameraRight.y = 0;
        cameraForward.Normalize();
        cameraRight.Normalize();
        Vector3 moveDirection = (cameraForward * moveZ + cameraRight * moveX).normalized;
        playerRb.velocity = new Vector3(moveDirection.x * moveSpeed, playerRb.velocity.y, moveDirection.z * moveSpeed)*Time.deltaTime;
    }
    
    
}
