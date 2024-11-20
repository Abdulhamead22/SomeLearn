using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{
    

public struct Position 
{
    public float x;
    public float y;
    public float z;

    public Position(float one,float tow,float three){
        x=one;y=tow;z=three;
    }
    public void PrintPosition(){
        Debug.Log("x = "+x + " y = "+y +" z = "+z );
    }
    
}
}