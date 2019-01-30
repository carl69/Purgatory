using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDealDamage : MonoBehaviour
{
    public Card attack;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            other.GetComponent<DummyTakeDamage>().TakeDamage(attack);
        }
    }
}
