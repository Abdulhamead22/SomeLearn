using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : Charactar
{
    public  Enemy(string nameEnemy, int healthEnemy) :base(nameEnemy,healthEnemy)
    {
        
    }

    public void Attack(Charactar character, int attacks)
    {
        character.Health -= attacks;
        // Debug.Log("The New Health: "+ character.Health);
    }
}
