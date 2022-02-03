using CombatSystem;
using InputSystem;
using MovementSystem;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    ICanMove2D movementController;
    IDamagable damageController;
    IHaveHealth healthController;
    IDestroyable destroyController;
    public IInput MoveLeftInput;
    public IInput MoveRightInput;
    public IInput MoveUpInput;
    public IInput MoveDownInput;

    private void Awake()
    {
        InitializeInterfaces();
        SetEvents();
    }

    void InitializeInterfaces()
    {
        movementController = GetComponent<ICanMove2D>();
        if (movementController == null) Debug.Log("No Movement Controller", gameObject);
        damageController = GetComponent<IDamagable>();
        if (damageController == null) Debug.Log("No Damage Controller", gameObject);
        healthController = GetComponent<IHaveHealth>();
        if (healthController == null) Debug.Log("No Health Controller", gameObject);
        destroyController = GetComponent<IDestroyable>();
        if (destroyController == null) Debug.Log("No Destroy Controller", gameObject);
    }

    void SetEvents()
    {
        damageController.OnDamaged.AddListener(GetDamaged);
        healthController.OnHealthBelowZero.AddListener(destroyController.GetDestroyed);
        MoveLeftInput.OnInputCalled.AddListener(movementController.MoveLeft);
        MoveRightInput.OnInputCalled.AddListener(movementController.MoveRight);
        MoveUpInput.OnInputCalled.AddListener(movementController.MoveUp);
        MoveDownInput.OnInputCalled.AddListener(movementController.MoveDown);
    }

    void GetDamaged(int value)
    {
        healthController.ModifyHealth(-value);
    }

}
