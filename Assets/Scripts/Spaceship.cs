using System;
using CombatSystem;
using InputSystem;
using MovementSystem;
using UnityEngine;
using UnityEngine.Events;

public class Spaceship : MonoBehaviour
{
    ICanMove2D canMove2D;
    IDamagable damagable;
    IHaveHealth haveHealth;
    IDestroyable destroyable;
    IWeapon weapon;
    IInput moveLeftInput;
    IInput moveRightInput;
    IInput moveUpInput;
    IInput moveDownInput;
    IInput attackInput;

    private void Awake()
    {
        InitializeInterfaces();
    }

    void InitializeInterfaces()
    {
        canMove2D = GetComponent<ICanMove2D>();
        if (canMove2D == null)
            Debug.Log("No canMove2D", gameObject);
        damagable = GetComponent<IDamagable>();
        if (damagable == null)
            Debug.Log("No damagable", gameObject);
        else
            damagable.OnDamaged.AddListener(GetDamaged);
        haveHealth = GetComponent<IHaveHealth>();
        if (haveHealth == null)
            Debug.Log("No haveHealth", gameObject);
        else
            haveHealth.OnHealthBelowZero.AddListener(destroyable.GetDestroyed);
        destroyable = GetComponent<IDestroyable>();
        if (destroyable == null)
            Debug.Log("No destroyable", gameObject);
        weapon = GetComponent<IWeapon>();
        if (weapon == null)
            Debug.Log("No weapon", gameObject);

    }

    void GetDamaged(int value)
    {
        haveHealth.ModifyHealth(-value);
    }

    public void SetMoveRightInput(IInput input)
    {
        SetInput(moveRightInput, input, canMove2D.MoveRight);
    }

    public void SetMoveLeftInput(IInput input)
    {
        SetInput(moveLeftInput, input, canMove2D.MoveLeft);
    }

    public void SetMoveUpInput(IInput input)
    {
        SetInput(moveUpInput, input, canMove2D.MoveUp);
    }

    public void SetMoveDownInput(IInput input)
    {
        SetInput(moveDownInput, input, canMove2D.MoveDown);
    }

    public void SetAttackInput(IInput input)
    {
        SetInput(attackInput, input, weapon.Attack);
    }

    void SetInput(IInput inputToSet, IInput input, UnityAction action)
    {
        if (inputToSet != null)
            inputToSet.OnInputCalled.RemoveListener(action);
        inputToSet = input;
        inputToSet.OnInputCalled.AddListener(action);
    }

}