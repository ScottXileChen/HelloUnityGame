using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MainWeapons
{
    public Rifle()
    {
        WeaponObject = GameObject.Find("Hands_Automatic_rifle");
        WeaponObject.SetActive(false);
    }

    public override void Attack()
    {

    }
}
