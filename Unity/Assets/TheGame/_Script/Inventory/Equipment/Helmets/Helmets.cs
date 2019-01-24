using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmets : MonoBehaviour
{

    // A class for Helmet attributes
    class Helmet
    {
        private string tag;
        private float strength;
    }

    private List<Helmet> helmets =  new List<Helmet>();

}
