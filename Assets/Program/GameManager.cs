using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        player1.InitializePlayer("Abd",85);
        player1.Heal(10);
        player1.Heal(true);
    
        Player player2=new Player();
        player2.InitializePlayer("Malk",55);
        player2.Heal(25);
        player2.Heal(false);
        player2.ShowPlayerCount(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}