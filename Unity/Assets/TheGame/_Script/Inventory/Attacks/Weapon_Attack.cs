using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon_Attack : AttackItems
{
    // Constructor of the class
    public Weapon_Attack(string t, int Id) : base(t, Id)
    {
    }

    // New attributes for the magic card
    [SerializeField]
    private float attack_Power;
    public float Attack_Power
    {
        get { return this.attack_Power; }
        set { this.attack_Power = value; }
    }

}
