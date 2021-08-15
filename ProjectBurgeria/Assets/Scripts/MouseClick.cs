using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField]
    Vector3 GoToPosition = new Vector3(0,0,-1);
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        this.GetComponent<Transform>().position = GoToPosition;
    }
}
