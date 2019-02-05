using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDealDamage : MonoBehaviour
{
    public Card attack;
    BoxCollider bCollider;

    private void Start()
    {
        bCollider = this.transform.GetComponent<BoxCollider>();
        bCollider.enabled = false;

    }

    public void Attack(Vector2 attackTime)
    {
        StartCoroutine("EnableAttack", attackTime);
    }
    IEnumerator EnableAttack( Vector2 attackT)
    {
        yield return new WaitForSeconds(attackT.x);
        bCollider.enabled = true;
        yield return new WaitForSeconds(attackT.y);
        bCollider.enabled = false;


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            bCollider.enabled = false;
            other.GetComponent<DummyTakeDamage>().TakeDamage(attack);
        }
    }
}
