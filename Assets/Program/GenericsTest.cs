using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> gameContainer = new GameContainer<string>();
        gameContainer.SetItem("Healing Potion");
        Debug.Log("Stored item: " + gameContainer.GetItem());

        Debug.Log(GameUtils.DescribeItem<string>(gameContainer.GetItem()));
        
    }


}
}