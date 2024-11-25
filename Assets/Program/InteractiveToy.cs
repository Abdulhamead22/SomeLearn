using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveToy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    
    {
         float move = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * move);

        if (Input.GetKeyUp(KeyCode.E))
        {
            transform.Translate(Vector3.up);
            
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.Translate(Vector3.left);
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Translate(Vector3.right);
            
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            transform.Translate(Vector3.down);
            
        }

    }
}
