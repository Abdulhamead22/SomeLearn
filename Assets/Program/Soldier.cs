using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    

public class Soldier : Charactar
{
        public Soldier(string name, int health, Position position) : base(name, health, position) {}
public Soldier():base(){}
        public override void DisplayInfo()
        {
                base.DisplayInfo();
                Debug.Log("Soldier");
        
        }

    
}
}