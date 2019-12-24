﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float _mouseSensitivity;
    private float _xRotation;
    private float _yRotation;
    public Transform _playerBody;
    // Start is called before the first frame update
    void Start()
    {
        _xRotation = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 60f);

        _yRotation += Vector3.up.y * mouseX * _mouseSensitivity * Time.deltaTime;

        _playerBody.localRotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
    }
}
