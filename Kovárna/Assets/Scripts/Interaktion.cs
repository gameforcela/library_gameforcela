using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Interaktion : MonoBehaviour
{

    public GameObject ObjectI;
    public bool ObjectActive = false;

    public GameObject MoveManager;


    public void OnMouseDown()
    {

        ObjectActive = true;
        if (ObjectActive == true)
        {
            ObjectI.SetActive(true);
            MoveManager.SetActive(false);

        }
        else
        {
            ObjectI.SetActive(false);
            MoveManager.SetActive(true);
        }


    }



}