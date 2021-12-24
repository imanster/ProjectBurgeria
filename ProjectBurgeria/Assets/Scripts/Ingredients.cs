using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour
{
    [SerializeField]
    Vector3 StartPosition = new Vector3(0,-2.25f, -2), PositionChange = new Vector3(0, 0.75f, -1);

    public Vector3 CurrentPosition;

    public int IngredientsAdded;

    public bool TopBreadAdded;

    private void Start()
    {
        CurrentPosition = StartPosition;
        IngredientsAdded = 0;
        TopBreadAdded = false;
    }
    public void AddIngredient(int IngredientNumber)
    {
        CurrentPosition += PositionChange;

        if(IngredientNumber!=0)
            IngredientsAdded += (int)Mathf.Pow(2, IngredientNumber - 1);
    }

    public void Reset()
    {
        //Taking all gameobjects/ingredients which can be added to sandwich (aka which have MouseClick Script)
        // and calling the reset function in the script
        MouseClick[] MClicks = this.GetComponentsInChildren<MouseClick>();
        foreach (MouseClick MClick in MClicks)
        {
            MClick.Reset();
        }
        CurrentPosition = StartPosition;
        IngredientsAdded = 0;
        TopBreadAdded = false;
    }
}
