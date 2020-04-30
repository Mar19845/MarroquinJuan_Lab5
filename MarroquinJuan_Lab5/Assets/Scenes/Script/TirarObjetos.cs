using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirarObjetos : MonoBehaviour
{
    public float fuerza = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5,0.5f));

        if(Input.GetMouseButtonDown(0))
        {
            //if((Physics.Raycast(transform.position, Vector3.down, out hitInfo, 3))
            if(Physics.Raycast(ray,out hit,100.0f))
            {
                //Debug.DrawRay(transform.position, Vector3.down * 3, Color.green);
                if(hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    Rigidbody rb;
                    if(rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        AlCielo(rb);
                        PrintName(hit.transform.gameObject);
                    }
                }
            }
        }
    }
    private void PrintName(GameObject objeto)
    {
        print(objeto.name);

    }
    private void AlCielo(Rigidbody rig)
    {
        rig.AddForce(rig.transform.forward* fuerza, ForceMode.Impulse);


    }
}
