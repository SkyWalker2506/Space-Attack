using InputSystem;
using MovementSystem;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    ICanMove2D canMove2D;
    IInput moveInput;

    private void Awake()
    {
        InitializeInterfaces();
    }

    void InitializeInterfaces()
    {
        canMove2D = GetComponent<ICanMove2D>();
        if (canMove2D == null)
            Debug.Log("No canMove2D", gameObject);
    }

    public void SetMoveInput(IInput input)
    {
        InputUtility.SetInput(moveInput, input, canMove2D.MoveDown);
    }

}