using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //Interacting with things
    [SerializeField] PlayerStats playerStats;
    public float interactRange;
    public LayerMask layerMask;

    //Holding physics objects
    [SerializeField] private Rigidbody holdLocation;
    [SerializeField] private float dragSpeed;
    public float throwForce = 10f;
    private HoldComponent currentHit;
    private HoldComponent currentHeld;
    private ConfigurableJoint currentJoint;

    private void Awake()
    {
        if(!holdLocation)
            holdLocation = GameObject.Find("PickedUpItemHolder").GetComponent<Rigidbody>();
    }

    //Activating an interactable object
    public void OnInteract()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactRange, layerMask))
        {
            if (hit.transform.GetComponent<InteractComponent>(out InteractComponent interactComponent))
            {
                interactComponent.OnInteract(playerStats);
            }
        }
    }

    //Picking up a physics object
    public void PickUp()
    {
        currentJoint = currentHit.gameObject.AddComponent<ConfigurableJoint>();

        currentHeld = currentHit;
    }

    //Releasing the held object
    public void Release()
    {
        Destroy(currentJoint);

        currentHeld.Rigidbody.AddExplosionForce(throwForce, holdLocation.position, 1f, .5f, ForceMode.Impulse);
        currentHeld = null;
    }

    public void OnHold()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactRange, layerMask))
        {
            if (hit.transform.GetComponent<HoldComponent>(out HoldComponent holdComponent))
            {
                if(holdComponent != currentHeld)
                {
                    if(currentHeld)
                        currentHeld.MarkActive(false);
                }
            }
        }
    }

}
