using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set movement animation parameter
        bool isMoving = _playerMovement.IsMoving;
        _animator.SetBool("IsMoving", isMoving);

        // Set running animation parameter
        bool isRunning = _playerMovement.IsRunning;
        _animator.SetBool("IsRunning", isRunning);
    }
}
