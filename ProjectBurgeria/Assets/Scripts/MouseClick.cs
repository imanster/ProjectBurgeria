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
    int IngredientNumber = 0;

    [SerializeField]
    bool InitiallyInvisible = true;

    bool Clicked = false;
    Ingredients Ing;
    Vector3 InitialPosition;
    private void Start()
    {
        Ing = IngredientManager.GetComponent<Ingredients>();
        InitialPosition = this.GetComponent<Transform>().position;
        if(InitiallyInvisible)
            this.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if(!Clicked)
        {
            Clicked = true;
            this.GetComponent<Transform>().position = Ing.CurrentPosition + Offset;
            Ing.AddIngredient(IngredientNumber);
            if (InitiallyInvisible)
                this.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    public void Reset()
    {
        if (InitiallyInvisible)
            this.GetComponent<SpriteRenderer>().enabled = false;
        if (Clicked)
        {
            this.GetComponent<Transform>().position = InitialPosition;
        }
        Clicked = false;
    }
}
