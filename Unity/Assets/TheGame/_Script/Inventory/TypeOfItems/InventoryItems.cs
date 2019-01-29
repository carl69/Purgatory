using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItems
{
    [SerializeField]
    private string tag;


    public InventoryItems(string t)
    {
        this.tag = t;
    }

    public string getTag()
    {
        return this.tag;
    }

}
