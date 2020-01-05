using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    protected int _attackPower;
    private GameObject weaponObject;

    public GameObject WeaponObject { get => weaponObject; set => weaponObject = value; }

    public abstract void Update();
}
