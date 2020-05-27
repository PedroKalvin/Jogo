using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MouseMoviment : MonoBehaviour
{
    public float sensibilidade = 100f;

    public Transform corpoDoPlayer;

    float xRotacao = 0f;
 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        xRotacao -= mouseY;
        xRotacao = Mathf.Clamp(xRotacao, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotacao, 0f, 0f);
        corpoDoPlayer.Rotate(Vector3.up * mouseX);
    }
}