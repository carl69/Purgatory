using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MagicCard : CardItems
{

    public MagicCard(string t, int id) : base(t, id)
    {
    }

    // New variables for the magic card
    [SerializeField]
    private float Magic_Power;


    // Method to access the strength of the helmets
    public float getMagicPower()
    {
        return Magic_Power;
    }

}
