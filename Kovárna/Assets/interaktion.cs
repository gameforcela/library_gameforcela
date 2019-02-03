using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaktion : MonoBehaviour
{

    private bool dOpen = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
       
    }
}