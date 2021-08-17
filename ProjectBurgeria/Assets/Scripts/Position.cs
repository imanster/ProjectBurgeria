using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField]
    Vector3 StartPosition = new Vector3(0,-2.25f, -2), PositionChange = new Vector3(0, 0.75f, -1);

    public Vector3 CurrentPosition;

    private void Start()
    {
        CurrentPosition = StartPosition;
    }
    public void UpdatePosition()
    {
        CurrentPosition += PositionChange;
    }
}
