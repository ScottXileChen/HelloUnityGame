﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("WalkingSpeed", Mathf.Abs(Input.GetAxis("Vertical") + Input.GetAxis("Horizontal")));
    }
}
