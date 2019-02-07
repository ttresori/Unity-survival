using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Chess_Cube : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string TagCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
          //  Debug.Log("stay");
          /*  if (other.gameObject.tag == TagCollision)
                if (Input.GetButton("Fire1"))
                    Debug.Log("MOUSE1DOWN");*/

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            Debug.Log("exit");
        }
    }
}
