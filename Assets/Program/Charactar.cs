using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactar
{
    // Start is called before the first frame update

    private string name;
    private int health;

    public string Name     // Property 
    {
        get
        {
            return name;
        }
        set
        {
            name = value;

        }
    }
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
    public Charactar(string name, int health)
    {
        name = Name;
        health = Health;
    }
}