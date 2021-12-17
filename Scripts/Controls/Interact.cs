using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float interactRange;
    public LayerMask layerMask;

    public void OnInteract()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactRange, layerMask))
        {
            if (hit.transform.GetComponent<InteractComponent>())
            {
                hit.transform.GetComponent<InteractComponent>().OnInteract();
            }
        }
    }
}
