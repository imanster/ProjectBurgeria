using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serve : MonoBehaviour
{
    [SerializeField]
    Game g;
    private void OnMouseDown()
    {
        g.Serve();
    }
}
