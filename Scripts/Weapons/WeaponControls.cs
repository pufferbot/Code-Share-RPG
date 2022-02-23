using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControls : MonoBehaviour
{

    public LayerMask layerMask;
    public PlayerStats playerStats;
    int animLayer = 0;
    public bool isAttacking = false;

    public void OnAttack()
    {
        if(playerStats.equippedItem is MeleeWeapon meleeWeapon && !isAttacking)
            StartMeleeAttack(meleeWeapon);

    }

    public void StartMeleeAttack(MeleeWeapon meleeWeapon)
    {
        isAttacking = true;
        print("Attacking with " + meleeWeapon.itemName);
        playerStats.heldItem.GetComponent<Animator>().SetTrigger("Attack");
    }

    public void MeleeAttack(){
        if(playerStats.equippedItem is MeleeWeapon meleeWeapon)
        {
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

    bool isPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }
}
