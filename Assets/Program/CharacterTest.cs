using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Officer officer=new Officer("Abd",80,new Position(10,10,10));
        Soldier soldier=new Soldier();

        Charactar[] charactars=new Charactar[2];
        charactars[0]=officer;
        charactars[1]=soldier;

        for (int i = 0; i < charactars.Length; i++)
        {
            charactars[i].DisplayInfo();
        }
                Debug.Log("Health before attack: "+soldier.Health);
                officer.Attack( soldier,10, "Attacks"); // Officer attacks Soldier with attackType
                Debug.Log("Health after attack: "+soldier.Health);

    }

    
}
