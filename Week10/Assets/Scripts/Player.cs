using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            inventory.Save();
        }
        if (Input.GetKey(KeyCode.L))
        {
            inventory.Load();
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
        
    }
}
