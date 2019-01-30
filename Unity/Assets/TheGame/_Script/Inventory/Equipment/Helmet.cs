using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Helmet : EquipmentItems
{
    // Constructor for the class
    public Helmet(string t, int Id) : base(t, Id)
    {
    }

    // New attributes for the helmet
    [SerializeField]
    private float strength;
    public float Strength
    {
        get { return this.strength; }
        set { this.strength = value; }
    }

}
