using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController _characterController;

    [SerializeField]
    private float _moveSpeed;
    private Vector3 _move;
    private bool _isMoving;

    [SerializeField]
    private float _runSpeed;
    private bool _isRunning;

    [SerializeField]
    private float _jumpHeight;
    private float _gravity;
    private bool _isGrounded;
    private Vector3 _velocity;

    public bool IsGrounded { get => _isGrounded; private set => _isGrounded = value; }
    public Vector3 Move { get => _move; private set => _move = value; }
    public bool IsRunning { get => _isRunning; private set => _isRunning = value; }
    public bool IsMoving { get => _isMoving; private set => _isMoving = value; }

    void Start()
    {
        _characterController = gameObject.GetComponent<CharacterController>();
        Move = Vector3.zero;
        _gravity = -9.8f;
        _velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Check is grounded
        IsGrounded = _characterController.isGrounded;

        // Reset y value of velocity when is grounded
        if (IsGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        // Get input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Get running input and set is running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            IsRunning = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            IsRunning = false;
        }

        // Set move direction
        Move = transform.right * horizontal + transform.forward * vertical;

        // Check is moving
        if (Move.magnitude != 0)
        {
            IsMoving = true;
        }
        else
        {
            IsMoving = false;
        }

        // Character movement
        if(IsRunning)
        {
            _characterController.Move(Move * _runSpeed * Time.deltaTime);
        }
        else
        {
            _characterController.Move(Move * _moveSpeed * Time.deltaTime);
        }

        // Get jump input and set jump height
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            _velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }

        // Update y value of velocity and make character jump
        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }
}
