using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControlScript : MonoBehaviour
{
    private float turningSpeed = 180;
    public Transform cubetemplate;
    private float playerSpeed = 15.0f;
    private float playerSprint = 25.0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       


        // s = u t   s- distance  = u (velocity) * t (time)
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * playerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * playerSpeed;
        }
            if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime * 0.5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down, -turningSpeed * Time.deltaTime * 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cubetemplate, transform.position + transform.forward, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime * 250;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.forward * Time.deltaTime * playerSprint;
        }

    }
}
