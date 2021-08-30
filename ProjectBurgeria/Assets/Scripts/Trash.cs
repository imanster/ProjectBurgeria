using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField]
    Game g;
    private void OnMouseDown()
    {
        g.Trash();
    }
}
