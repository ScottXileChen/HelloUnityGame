using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    protected int _attackPower;
    public abstract void Start();
    public abstract void Update();
}
