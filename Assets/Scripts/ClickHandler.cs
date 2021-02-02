using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ClickHandler : MonoBehaviour
{
    public GameObject cube;
    public UnityEvent upEvent;
    public UnityEvent downEvent;

    void OnMouseDown()
    {
        cube.transform.position = new Vector3(transform.position.x,transform.position.y,1);
        Debug.Log("Down");
        downEvent?.Invoke();
    }
    void OnMouseUp()
    {
        cube.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        Debug.Log("Up");
        upEvent?.Invoke();
    }
}