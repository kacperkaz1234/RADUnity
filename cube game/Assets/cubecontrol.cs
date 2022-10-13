using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cubecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = u t   s- distance  = u (velocity) * t (time)
       
        {
            transform.position += transform.forward * Time.deltaTime * 100;
        }
        
        
    }
}
