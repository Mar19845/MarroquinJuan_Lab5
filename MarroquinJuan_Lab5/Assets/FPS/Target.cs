using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float health  = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health<= 0)
        {
            Morir();
        }
    }
    void Morir()
    {
        Destroy(gameObject);
        Contador.scoreval += 10;
    }
}
