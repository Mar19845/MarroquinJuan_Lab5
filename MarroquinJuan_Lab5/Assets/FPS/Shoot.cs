using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Shoot : MonoBehaviour
    {
        public FirstPersonController fps;
        public float upRecoil;
        public float sideRecoil;
        private AudioSource sound;
        public float range = 100f;
        public float damage = 10f;
        public float FuerzaImpacto = 30f;
        public float FireRate = 15f;
        public float NextFire = 0f;
        public Camera fpsCam;
        public ParticleSystem muzzle;
        public GameObject impact;   
        // Start is called before the first frame update
        void Start()
        {
            sound = GetComponent<AudioSource>();
        }
        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0) && Time.time>= NextFire)
            //if(Input.GetMouseButton(0) && Time.time>= NextFire)
            {
                NextFire = Time.time + 1f/FireRate; 
                //fps.m_MouseLook.AddRecoil(upRecoil,sideRecoil);
                sound.Play();
                Disparo();
            }
        }
        void Disparo()
        {
            muzzle.Play();
            RaycastHit hit;
            if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit, range ))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if(target!= null)
                {
                    target.TakeDamage(damage);  
                }
                if(hit.rigidbody!=null)
                {
                    hit.rigidbody.AddForce(-hit.normal*FuerzaImpacto);
                }
                GameObject impactGO=Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO,2f);
            }
        }
    }
}
