using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactar
{
    // Start is called before the first frame update

    protected static string name;
    protected static int health;

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
    public  Charactar(string name1, int health1)
    {
        name = name1;
        health = health1;
    }
}