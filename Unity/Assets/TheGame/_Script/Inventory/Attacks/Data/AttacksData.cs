using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacksData : InventoryItems
{
    // Constructor of the class
    public AttacksData(string t, int Id) : base(t, Id)
    {
    }

    [SerializeField]
    private string attackAnimation;
    public string AttackAnimation { get { return this.attackAnimation; } }

    private int comboNumber;
    public int ComboNumber { get { return this.comboNumber; } set { this.comboNumber = value; } }

}
