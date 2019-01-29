using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItems
{
    [SerializeField]
    private string tag;
    [SerializeField]
    private int Id;


    public InventoryItems(string t, int id)
    {
        this.tag = t;
        this.Id = id;
    }

    // Method to get the tag
    public string getTag()
    {
        return this.tag;
    }

    // Method to get the id of the elements
    public int getId()
    {
        return this.Id;
    }
}
