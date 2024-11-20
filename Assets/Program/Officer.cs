using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    

public class Officer : Charactar
{
    public Officer(string name, int health, Position position) : base(name, health, position) {}
public Officer():base(){}
        public override void DisplayInfo()
        {
                base.DisplayInfo();
                Debug.Log("Officer");
        
        }

    }
}