using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class health : MonoBehaviour
{

    int CHP;
    public int MHP = 50;

    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
  

    }


    internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("Ouch you hurt me my health is now " + CHP);

        if(CHP <= 0)
            Destroy(gameObject);
        killsscript.instance.AddPoint();

    }
    internal int whatsYourMaxHealth()
    {
        return MHP;
    }
}