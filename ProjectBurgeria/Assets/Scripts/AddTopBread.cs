using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTopBread : MonoBehaviour
{

    [SerializeField]
    GameObject IngredientManager;

    Ingredients Ing;
    private void Start()
    {
        Ing = IngredientManager.GetComponent<Ingredients>();
    }

    private void OnMouseDown()
    {
        if (!Ing.TopBreadAdded)
            Ing.TopBreadAdded = true;
    }
}
