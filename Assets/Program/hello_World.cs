using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Debug.Log: طباعة المتغير string
Debug.LogWarning: تسجيل رسالة تحذيرية في Console
Debug.LogError: تسجيل رسالة خطأ في Console

*/
public class hello_World : MonoBehaviour
{
    // Start is called before the first frame update
    public int mynumber=10;
    public string myString = "Hello World";
    void Start()
    {
        int result=mynumber*5;
        Debug.Log("Result = " + result);

        Debug.Log(myString);

        Debug.LogWarning("Warning Message!");

        Debug.LogError("Error Message!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
