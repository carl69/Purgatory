using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Helmet : EquipmentItems
{
    public Helmet(string t, int id) : base(t, id)
    {
    }
     

    // New variables for the helmet
    [SerializeField]
    private float strength;

    public float getStrength()
    {
        return strength;
    }
}
