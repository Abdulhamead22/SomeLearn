using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playercharactar :Charactar
{
    public  playercharactar(string nameplayer,int healthplayer): base(nameplayer,healthplayer){

    }
    public void Heal(int amount){
            health+=amount;
            
        }
}