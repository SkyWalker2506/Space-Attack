using System.Collections;
using System.Collections.Generic;
using CombatSystem;
using UnityEngine;
using UnityEngine.Events;

public class HealthWithLimit : MonoBehaviour, IHaveHealth
{
    [SerializeField] int minValue; 
    [SerializeField] int maxValue; 
    public int Health { get; private set; }

    [SerializeField]UnityEvent onHealthChanged;
    public UnityEvent OnHealthChanged => onHealthChanged;


    public void ModifyHealth(int value)
    {
        SetHealth(Health + value);
    }

    public void SetHealth(int health)
    {
        var oldValue = Health;
        Health = Mathf.Clamp(health,minValue,maxValue);
        if(oldValue!=health)
            OnHealthChanged?.Invoke();
    }

}
