using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItems : MonoBehaviour
{
    [SerializeField]
    protected string tag;

    public InventoryItems(string t)
    {
        this.tag = t;
    }

}
