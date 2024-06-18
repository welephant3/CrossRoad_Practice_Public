using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private MainController mainController;
    private Rigidbody mainRigidbody;    

    private Vector3 movementDirection = Vector3.zero;

    private void Awake()
    {
        mainController = GetComponent<MainController>();
        mainRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        mainController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector3 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector3 direction)
    {
        direction *= speed;

        mainRigidbody.velocity = direction;
    }
}