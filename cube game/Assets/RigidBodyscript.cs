using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyscript : MonoBehaviour
{
    Rigidbody ourRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddForce (Vector3.up);
        }
    }
}
