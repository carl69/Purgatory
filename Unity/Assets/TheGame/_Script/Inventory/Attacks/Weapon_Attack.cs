using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon_Attack : AttacksData
{
    // Constructor of the class
    public Weapon_Attack(string t, int Id) : base(t, Id)
    {
    }

    // Struct with the stats
    [SerializeField]
    private WeaponAttackStats weaponAttackStats;
    public WeaponAttackStats WeaponAttackStats { get { return this.weaponAttackStats; } }
}
