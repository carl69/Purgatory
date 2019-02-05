using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIdentifier : MonoBehaviour
{
    public enum items { Equipment, Attacks, Weapons}

    [SerializeField]
    private items item;
    public items Item { get { return this.item; } }

    [SerializeField]
    private int objectId;
    public int ObjectId { get { return this.objectId; } }
}
