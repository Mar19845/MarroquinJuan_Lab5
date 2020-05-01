using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float health  = 50;
    public float time;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
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
            sound.Play();
            Contador.scoreval += 10;
            Morir();
        }
    }
    void Morir()
    {
        Destroy(gameObject,time);
    }
}
