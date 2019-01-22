using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
    public string Name;
    [TextArea]
    public string Description;

    public int ComboCost;
    public float StaminaCost;

    public enum cardType
    {
        Attack,Magic,Enchant
    }
    public cardType CardType;
    [Space]
    public Sprite CardSprite;
    public Animation AttackAnimation;
}