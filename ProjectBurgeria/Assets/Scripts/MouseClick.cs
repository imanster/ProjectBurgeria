using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField]
    Vector3 Offset = new Vector3(0,0,0);

    [SerializeField]
    GameObject IngredientManager;

    Position pos;
    private void Start()
    {
        pos = IngredientManager.GetComponent<Position>();
    }
    private void OnMouseDown()
    {
        this.GetComponent<Transform>().position = pos.CurrentPosition+Offset;
        pos.UpdatePosition();

    }
}
