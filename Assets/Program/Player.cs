using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string playerName;
    int health;
    static int playerCount;
    public void InitializePlayer(string name, int initialHealth){
        playerName=name;
        health=initialHealth;
        playerCount++;
    }
    public void Heal(int amount){
        health+=amount;
        Debug.Log("The New Health: "+ health);
    }
    public void Heal(bool fullRestore){
if (fullRestore==true)
{
    health=100;
    Debug.Log(playerName+" is Full Health");
}
    }
    public void ShowPlayerCount(){
        Debug.Log(playerCount);
    }
}