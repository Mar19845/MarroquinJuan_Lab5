using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseEnter() 
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    /// <summary>
    /// Called when the mouse is not any longer over the GUIElement or Collider.
    /// </summary>
    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    /// <summary>
    /// OnMouseUp is called when the user has released the mouse button.
    /// </summary>
    private void OnMouseUp()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
