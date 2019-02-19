using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell_Attack : AttacksData
{
    // Constructor of the cards
    public Spell_Attack(string t, int Id) : base(t, Id)
    {
    }

    // Struct with the stats
    [SerializeField]
    private SpellAttackStats spellAttackStats;
    public SpellAttackStats SpellAttackStats { get { return this.spellAttackStats; } }
}
