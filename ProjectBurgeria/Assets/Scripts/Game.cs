using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    int Score;

    [SerializeField]
    int CorrectBonus=1, WrongPenalty=2;

    public int Order;

    [SerializeField]
    int NumberOfIngredients;

    [SerializeField]
    GameObject IngredientManager;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        GenerateRandomOrder();
    }

    void GenerateRandomOrder()
    {
        Order = Random.Range(0, (int)Mathf.Pow(2, NumberOfIngredients));
    }

    public void Serve()
    {
        int SandwichServed = IngredientManager.GetComponent<Ingredients>().IngredientsAdded;
        if (SandwichServed == Order)
            Score += CorrectBonus;
        else
            Score -= WrongPenalty;
        GenerateRandomOrder();
    }

    public void Trash()
    {

    }
}
