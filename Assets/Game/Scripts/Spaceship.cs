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

    void Awake()
    {
        InitializeInterfaces();
    }

    private void OnDisable()
    {
        SetMoveRightInput(null);
        SetMoveLeftInput(null);
        SetMoveUpInput(null);
        SetMoveDownInput(null);
        SetAttackInput(null);
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
        destroyable = GetComponent<IDestroyable>();
        if (destroyable == null)
            Debug.Log("No destroyable", gameObject);
        haveHealth = GetComponent<IHaveHealth>();
        if (haveHealth == null)
            Debug.Log("No haveHealth", gameObject);
        else if(destroyable != null)
            haveHealth.OnHealthBelowZero.AddListener(destroyable.GetDestroyed);

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
        InputUtility.SetInput(moveRightInput, input, canMove2D.MoveRight);
    }

    public void SetMoveLeftInput(IInput input)
    {
        InputUtility.SetInput(moveLeftInput, input, canMove2D.MoveLeft);
    }

    public void SetMoveUpInput(IInput input)
    {
        InputUtility.SetInput(moveUpInput, input, canMove2D.MoveUp);
    }

    public void SetMoveDownInput(IInput input)
    {
        InputUtility.SetInput(moveDownInput, input, canMove2D.MoveDown);
    }

    public void SetAttackInput(IInput input)
    {
        InputUtility.SetInput(attackInput, input, weapon.Attack);
    }

}