using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    [SerializeField]
    GameObject[] Icons;

    [SerializeField]
    UnityEngine.UI.Text ScoreDisplay;

    Ingredients Ing;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        GenerateRandomOrder();
        Ing = IngredientManager.GetComponent<Ingredients>();
        ScoreDisplay.text = "0";
    }

    void GenerateRandomOrder()
    {
        Order = Random.Range(0, (int)Mathf.Pow(2, NumberOfIngredients));

        int OrderCopy = Order;
        for(int i=0; i<NumberOfIngredients; i++)
        {
            Icons[i].SetActive(OrderCopy % 2 == 1);
            OrderCopy /= 2;
        }
    }

    public void Serve()
    {
        int SandwichServed = Ing.IngredientsAdded;
        if (SandwichServed == Order)
            Score += CorrectBonus;
        else
            Score -= WrongPenalty;
        ScoreDisplay.text = Score.ToString();
        GenerateRandomOrder();
        Ing.Reset();
    }

    public void Trash()
    {
        Ing.Reset();
    }
}
