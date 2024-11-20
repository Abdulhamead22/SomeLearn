using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory inventory=new Inventory();
    inventory.AddItem("Healing Potion");
        inventory.AddItem("Strength Potion");
        Inventory inventory1=new Inventory();
        inventory1.AddItem("Elixer");
        inventory1.AddItem("Dark Elixer");
        Inventory inventoryAll=inventory+inventory1;
        inventoryAll.ShowItems();
    }

    
}
}