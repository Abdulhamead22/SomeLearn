using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    

public class Officer : Charactar
{
    public Officer(string name, int health, Position position) : base(name, health, position) {}

        public override void DisplayInfo()
        {
                base.DisplayInfo();
                Debug.Log("Officer");
        
        }

    }
}