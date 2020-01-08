using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Weapons _currentWeapon;
    private Weapons _mainWeapon;
    private Weapons _secondWeapon;
    private Weapons _meleeWeapon;

    private int _weaponNum;
    private int _weaponOptionIndex;
    private bool _weaponSwitch;

    private bool _isAttacking;
    private bool _isReloading;
    private bool _isAiming;
    public bool IsAttacking { get => _isAttacking; set => _isAttacking = value; }
    public bool IsReloading { get => _isReloading; set => _isReloading = value; }
    public bool IsAiming { get => _isAiming; set => _isAiming = value; }

    // Start is called before the first frame update
    void Start()
    {
        _weaponNum = 2;
        _weaponOptionIndex = 0;
        _weaponSwitch = false;
        _meleeWeapon = new Axe();
        _mainWeapon = new Rifle();
        _currentWeapon = _mainWeapon;
        _currentWeapon.WeaponObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IsAttacking = true;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            IsAttacking = false;
        }

        if (_currentWeapon is MainWeapons)
        {
            if (Input.GetMouseButtonDown(1))
            {
                IsAiming = true;
            }
            else if (Input.GetMouseButtonUp(1))
            {
                IsAiming = false;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                IsReloading = true;
            }
            else if (Input.GetKeyUp(KeyCode.R))
            {
                IsReloading = false;
            }
        }

        if(_weaponSwitch)
        {
            switch (_weaponOptionIndex)
            {
                case 0:
                    _currentWeapon.WeaponObject.SetActive(false);
                    _currentWeapon = _mainWeapon;
                    _currentWeapon.WeaponObject.SetActive(true);
                    break;
                case 1:
                    _currentWeapon.WeaponObject.SetActive(false);
                    _currentWeapon = _meleeWeapon;
                    _currentWeapon.WeaponObject.SetActive(true);
                    break;
                default:
                    break;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weaponOptionIndex = 1;
            _weaponSwitch = true;
        }
    }
}
