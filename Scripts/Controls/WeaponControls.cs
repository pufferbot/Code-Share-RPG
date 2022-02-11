using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControls : MonoBehaviour
{

    public PlayerStats playerStats;

    public void OnAttack()
    {

        if(playerStats.equippedItem is MeleeWeapon)
            MeleeAttack();

    }

    public void MeleeAttack()
    {

        print("Attacking with " + playerStats.equippedItem.itemName);

    }

}
