using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItems
{
    // Attributes of the class
    [SerializeField]
    private string tag;
    public string Tag
    {
        get { return this.tag; }
        set { this.tag = value; }
    }

    [SerializeField]
    private int id;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    // Constructor of the class
    public InventoryItems(string t, int Id)
    {
        this.tag = t;
        this.id = Id;
    }
}
