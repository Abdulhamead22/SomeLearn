using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
while (true)
{
    int number=Random.Range(1,21);
    if (number==5)
    {
        Debug.Log("While is continue because the number = " +number);
        continue;
    }else if(number==15)
    {
        Debug.Log("While is break because the number = " +number);
        break;
    }
    Debug.Log(number);
}
int counter=0;
string sentence="";
string[] word={"Cat", "Dog","Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
while (counter<7)
{
    int rangeOfWords=Random.Range(0,word.Length);
    sentence+=word[rangeOfWords];
    counter++;
}
Debug.Log(sentence);
    }

    // Update is called once per frame
    
}
