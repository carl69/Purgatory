using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackCard : CardItems
{
    public AttackCard(string t, int id) : base(t, id)
    {
    }

    // New variables for the magic card
    [SerializeField]
    private float Attack_Power;


    // Method to access the strength of the helmets
    public float getAttackPower()
    {
        return Attack_Power;
    }
}
