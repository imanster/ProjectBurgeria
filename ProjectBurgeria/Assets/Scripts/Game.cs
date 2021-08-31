using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    public int Score;

    [SerializeField]
    int CorrectBonus=1, WrongPenalty=2;

    public int Order;

    [SerializeField]
    int NumberOfIngredients;

    [SerializeField]
    GameObject IngredientManager;

    Ingredients Ing;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        GenerateRandomOrder();
        Ing = IngredientManager.GetComponent<Ingredients>();
    }

    void GenerateRandomOrder()
    {
        Order = Random.Range(0, (int)Mathf.Pow(2, NumberOfIngredients));
    }

    public void Serve()
    {
        int SandwichServed = Ing.IngredientsAdded;
        if (SandwichServed == Order)
            Score += CorrectBonus;
        else
            Score -= WrongPenalty;
        GenerateRandomOrder();
        Ing.Reset();
    }

    public void Trash()
    {
        Ing.Reset();
    }
}
