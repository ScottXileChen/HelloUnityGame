﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Melees
{
    public Axe()
    {
        WeaponObject = GameObject.Find("Hands_Axe");
        WeaponObject.SetActive(false);
    }

    public override void Attack()
    {
        
    }
}
