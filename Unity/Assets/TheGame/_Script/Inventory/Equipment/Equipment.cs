using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    private Dictionary<string, List<GameObject>> equipment = new Dictionary<string, List<GameObject>>();

    public GameObject helmets;

    private void Start()
    {
        //equipment.Add(helmets.name, helmets.GetComponent<Helmets>().getHelmets());
    }
}
