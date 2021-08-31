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
    Sprite ChangeToSprite=null;

    [SerializeField]
    int IngredientNumber = 0;

    Sprite InitialSprite;
    bool Clicked = false;
    Ingredients Ing;
    Vector3 InitialPosition;
    private void Start()
    {
        Ing = IngredientManager.GetComponent<Ingredients>();
        InitialSprite = this.GetComponent<SpriteRenderer>().sprite;
        InitialPosition = this.GetComponent<Transform>().position;
    }

    private void OnMouseDown()
    {
        if(!Clicked)
        {
            Clicked = true;
            this.GetComponent<Transform>().position = Ing.CurrentPosition + Offset;
            Ing.AddIngredient(IngredientNumber);
            if (ChangeToSprite != null)
            {
                this.GetComponent<SpriteRenderer>().sprite = ChangeToSprite;
            }
        }
    }

    public void Reset()
    {
        this.GetComponent<Transform>().position = InitialPosition;
        if (ChangeToSprite != null && Clicked)
        {
            this.GetComponent<SpriteRenderer>().sprite = InitialSprite;
        }
        Clicked = false;
    }
}
