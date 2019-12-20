using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;
    private Animator _animator;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _jumpSpeed;
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        Vector3 displacement = new Vector3(horizontal * _moveSpeed * Time.deltaTime, jump * _jumpSpeed * Time.deltaTime, vertical * _moveSpeed * Time.deltaTime);
        _rigidbody.MovePosition(transform.position + displacement);

        _animator.SetFloat("WalkingSpeed", vertical);
    }
}
