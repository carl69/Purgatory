using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : EquipmentItems
{
    public Helmet(string t) : base(t)
    {
    }

    // New variables for the helmet
    [SerializeField]
    private float strength;
}
