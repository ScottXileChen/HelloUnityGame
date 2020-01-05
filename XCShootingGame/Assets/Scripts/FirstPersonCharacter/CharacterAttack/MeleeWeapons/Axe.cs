using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Melees
{
    public Axe()
    {
        WeaponObject = GameObject.Find("Hands_Axe");
        WeaponObject.SetActive(false);
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public override void Attack()
    {
        
    }
}
