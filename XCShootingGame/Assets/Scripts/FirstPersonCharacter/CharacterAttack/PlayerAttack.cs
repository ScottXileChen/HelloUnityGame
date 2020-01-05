using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Weapons _currentWeapon;
    private Weapons _MainWeapon;
    private Weapons _SecondWeapon;
    private Weapons _MeleeWeapon;

    private bool _IsAttacking;

    public bool IsAttacking { get => _IsAttacking; set => _IsAttacking = value; }

    // Start is called before the first frame update
    void Start()
    {
        _MeleeWeapon = new Axe();
        _currentWeapon = _MeleeWeapon;
        _currentWeapon.WeaponObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _IsAttacking = true;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            _IsAttacking = false;
        }
    }
}
