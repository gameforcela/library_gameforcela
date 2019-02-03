using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaktion : MonoBehaviour
{

    public GameObject Ore;
    public GameObject Hero;
    public bool OreActive = false;

    public void OnMouseEnter()
    {
        Debug.Log("ONMOUSE");
    }

    public void OnMouseExit()
    {
        Debug.Log("exit");
    }

    public void OnMouseDown()
    {
        Debug.Log("down");

        OreActive = true;
        if (OreActive == true)
        {
            Ore.SetActive(true);
        } else
        {
            Ore.SetActive(false);
        }       
    }

}