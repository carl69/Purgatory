using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmets : MonoBehaviour
{

    // A class for Helmet attributes
    [System.Serializable]
    public class Helmet
    {
        [SerializeField]
        private string tag;
        [SerializeField]
        private float strength;
    }

    [SerializeField]
    private List<Helmet> helmets = new List<Helmet>();

    public List<Helmet> getHelmets()
    {
        return helmets;
    }
}
