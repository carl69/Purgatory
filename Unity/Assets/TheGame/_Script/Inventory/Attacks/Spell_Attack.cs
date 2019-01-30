using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell_Attack : AttackItems
{
    // Constructor of the cards
    public Spell_Attack(string t, int Id) : base(t, Id)
    {
    }

    // New attributes for the magic card
    [SerializeField]
    private float magic_Power;
    public float Magic_Power
    {
        get { return this.magic_Power; }
        set { this.magic_Power = value; }
    }



}
