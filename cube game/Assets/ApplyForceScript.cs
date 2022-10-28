using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class ApplyForceScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody ourRigidBody;

    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        ;
        {

        }
      
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        health objectHitHealth = collision.gameObject.GetComponent<health>();

        if (objectHitHealth)
        {
            print("Found Health script in object hit");
            objectHitHealth.takeDamage(100);

            int ObjectsMaxHealth = objectHitHealth.whatsYourMaxHealth();
            if (ObjectsMaxHealth > 100)
                objectHitHealth.takeDamage(100);
            
        }
        else
        {

            print("Did'nt find Health script in object hit");
        }
    }


}