using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : InteractComponent
{
    [SerializeField] PlayerStats playerStats;
    public ItemInstance item;

    public override void OnInteract()
    {
        playerStats.inventory.InsertItem(item);
        Destroy(gameObject);
    }

}
