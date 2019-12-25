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

    [SerializeField]
    private float _jumpHeight;
    private float _gravity;
    private bool _isGrounded;
    private Vector3 _velocity;

    private float _groundDistance;
    public Transform _groundCheck;

    public bool IsGrounded { get => _isGrounded; private set => _isGrounded = value; }
    public Vector3 Move { get => _move; private set => _move = value; }

    void Start()
    {
        _characterController = gameObject.GetComponent<CharacterController>();
        Move = Vector3.zero;
        _gravity = -9.8f;
        _velocity = Vector3.zero;
        _groundDistance = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = _characterController.isGrounded;

        if (IsGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Move = transform.right * horizontal + transform.forward * vertical;
        _characterController.Move(Move * _moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            _velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }

        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }
}
