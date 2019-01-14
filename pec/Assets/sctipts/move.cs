using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject objekt;
    public GameObject temParent;
    public Transform center;

    void Start()
    {
        objekt.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseDown()
    {
        objekt.GetComponent<Rigidbody>().useGravity = false;
        objekt.GetComponent<Rigidbody>().isKinematic = true;
        objekt.transform.position = center.transform.position;
        objekt.transform.rotation = center.transform.rotation;
        objekt.transform.parent = temParent.transform;
    }

    void OnMouseUp()
    {
        objekt.GetComponent<Rigidbody>().useGravity = true;
        objekt.GetComponent<Rigidbody>().isKinematic = false;            
        objekt.transform.parent = null;
    }
}
