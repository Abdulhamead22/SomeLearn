using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    

public class Inventory 
{
    private List<string> items=new List<string>();
    public  void AddItem(string item){
     items.Add(item);
    
    }
    public void ShowItems(){
        
        foreach (string i in items){
Debug.Log(i);
        }
    }
    public static Inventory operator + (Inventory inventory1, Inventory inventory2){
        Inventory inventoryAll=new Inventory();
        
         inventoryAll.items.AddRange(inventory1.items );
                  inventoryAll.items.AddRange(inventory2.items );
                  return inventoryAll;

         

    }
}
}