using InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceshipAI : MonoBehaviour
{
    Spaceship spaceship;
    InputSystem.Input moveUpInput = new InputSystem.Input();
    InputSystem.Input attackInput = new InputSystem.Input();

    private void Start()
    {
        Initialize();
        InvokeRepeating(nameof(Attack), 1, 1);    
    }

    private void Update()
    {
        MoveForward();
    }

    private void Initialize()
    {
        spaceship = GetComponent<Spaceship>();
        spaceship.SetMoveUpInput(moveUpInput);
        spaceship.SetAttackInput(attackInput);
    }

    void Attack()
    {
            attackInput.CallInput();
    }

    void MoveForward()
    {
            moveUpInput.CallInput();
    }

}
