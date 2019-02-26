using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour
{
    public LayerMask clickableLayer;

    public Texture2D pointer;
    public Texture2D target;
    public Texture2D doorway;

    public EventVector3 OnClickEnvironment;

    void Update()
    {
        // Raycast into scene
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {

            // If environment surface is clicked, invoke callbacks.
            if (Input.GetMouseButtonDown(0)&&!EventSystem.current.IsPointerOverGameObject())
            {
                OnClickEnvironment.Invoke(hit.point);
            
                Debug.Log("HIT: " + hit.collider.gameObject);
            }
        }
        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }
