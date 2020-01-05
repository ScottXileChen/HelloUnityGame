using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerAttack _playerAttack;
    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        _playerAttack = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isAttacking = _playerAttack.IsAttacking;
        _animator.SetBool("IsAttacking", isAttacking);
    }
}
