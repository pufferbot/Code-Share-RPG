using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControls : MonoBehaviour
{

    public LayerMask layerMask;
    public PlayerStats playerStats;

    public void OnAttack()
    {
        if(playerStats.equippedItem is MeleeWeapon meleeWeapon)
            MeleeAttack(meleeWeapon);

    }

    public void MeleeAttack(MeleeWeapon meleeWeapon)
    {
        print("Attacking with " + meleeWeapon.itemName);
        playerStats.heldItem.GetComponent<Animator>().SetTrigger("Attack");
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, meleeWeapon.range, layerMask))
        {
            if (hit.transform.GetComponent<CharacterStats>())
            {
                hit.transform.GetComponent<CharacterStats>().DamageHealth(meleeWeapon.damage); //final damage = base damage * ((50 + (melee skill + strength*2))/100)
            }
        }
    }

}
