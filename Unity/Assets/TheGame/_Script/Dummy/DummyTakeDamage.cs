using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTakeDamage : MonoBehaviour
{

    public void TakeDamage(float DMG)
    {
        print("Poor dummy took: " + DMG.ToString() + " Damage, you rood asshole! >:(");
    }
}
