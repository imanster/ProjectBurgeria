using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serve : MonoBehaviour
{
    [SerializeField]
    Game g;

    [SerializeField]
    GameObject IngredientManager;

    Ingredients Ing;

    private void Start()
    {
        Ing = IngredientManager.GetComponent<Ingredients>();
    }
    private void OnMouseDown()
    {
        if(Ing.TopBreadAdded)
            g.Serve();
    }
}
