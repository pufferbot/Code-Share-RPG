using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Items/Melee Weapon", fileName = "NewMeleeWeapon.asset")]
public class MeleeWeapon : Item
{
    public int damage;
    public float attackSpeed;
    public bool twoHanded;
    public int blockStrength;
    public enum damageType{
        Magic, Electric, Blunt
    }
}
