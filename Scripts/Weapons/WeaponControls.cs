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
<<<<<<< HEAD
        //print("Attacking with " + meleeWeapon.itemName);
=======
        print("Attacking with " + meleeWeapon.itemName);
>>>>>>> main
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
<<<<<<< HEAD
                    float finalDamage = meleeWeapon.damage * ((50f + (playerStats.skill_Melee.GetValue() + playerStats.strength.GetValue() * 2f)) / 100f);
                    print(finalDamage);
                    hit.transform.GetComponent<CharacterStats>().DamageHealth(Mathf.RoundToInt(finalDamage)); //final damage = base damage * ((50 + (melee skill + strength*2))/100) rounded to nearest integer
=======
                    hit.transform.GetComponent<CharacterStats>().DamageHealth(meleeWeapon.damage); //final damage = base damage * ((50 + (melee skill + strength*2))/100)
>>>>>>> main
                }
            }
        }
    }

    bool isPlaying(Animator anim, string stateName)
    {
<<<<<<< HEAD
        if (anim.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) && anim.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
=======
        if (anim.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
>>>>>>> main
            return true;
        else
            return false;
    }
}
