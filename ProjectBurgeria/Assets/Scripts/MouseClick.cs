using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField]
    Vector3 Offset = new Vector3(0,0,0);

    [SerializeField]
    GameObject IngredientManager;

    [SerializeField]
    Sprite ChangeTo=null;

    [SerializeField]
    int IngredientNumber = 0;

    bool clicked = false;

    Ingredients pos;

    private void Start()
    {
        pos = IngredientManager.GetComponent<Ingredients>();
    }

    private void OnMouseDown()
    {
        if(!clicked)
        {
            clicked = true;
            this.GetComponent<Transform>().position = pos.CurrentPosition + Offset;
            pos.AddIngredient(IngredientNumber);
            if (ChangeTo != null)
            {
                this.GetComponent<SpriteRenderer>().sprite = ChangeTo;
            }
        }
    }
}
