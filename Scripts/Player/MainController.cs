using System;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public event Action<Vector3> OnMoveEvent;

    public void CallMoveEvent(Vector3 direction)
    { 
        OnMoveEvent?.Invoke(direction);
    }
}
