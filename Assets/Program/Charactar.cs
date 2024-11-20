using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Assignment16
{
    

public class Charactar
{
    // Start is called before the first frame update

    public  string name;
    private  int health;
    protected Position position;
   
    
    public int Health     // Property 
    {
        get
        {
            return health;
        }
        set
        {
            if (value> 100) health = 100;
              else if (value < 0) health = 0;
              else health = value;

        }

    }
    public  Charactar(string name1, int health1,Position position1)
    {
        name = name1;
        health = health1;
        position=position1;
    }
public Charactar() : this("No name", 100,  new Position()) {}
public virtual void DisplayInfo(){
    Debug.Log("The Name: "+name + " The Health: "+health);
    position.PrintPosition();   
}

    public void Attack(Charactar character, int attacks)
    {
        character.Health -= attacks;
        
    }
    public void Attack(Charactar character,int attacks,string attackType)
    {
        Attack(character,attacks);
        Debug.Log("The Type of Attacks: "+attackType);
        
    }
}}