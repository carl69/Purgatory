using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct LegStats
{
    [SerializeField]
    private float endurance;
    public float Endurance { get { return this.endurance; } }
}
