using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerManager", menuName = "PlayerManager", order = 51)]
public class PlayerManager : ScriptableObject
{
    [SerializeField]
    private float stamina;
}
