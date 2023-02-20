using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager inventory = other.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                InventoryManager.Instance.Add(Item);
                Destroy(gameObject);
            }
        }

    }

    //private void OnMouseDown()
    // {
    //     Pickup();
    // }
}
