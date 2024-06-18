using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MainController
{
    public void OnMove(InputValue value)
    {
        Vector3 moveInput = value.Get<Vector3>().normalized;
        CallMoveEvent(moveInput);        
    }     
}
