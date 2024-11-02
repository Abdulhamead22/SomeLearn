using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number=5;
        for (int i = 1; i <=10 ; i++)
        {
            Multiply(number,10);
            int result= i*number;
            Debug.Log(number + " * "+ i +" = " + result);
        }
    }
    


    int Multiply(int num1,int num2)
    {
        return num1 * num2;
}
}