using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class HealthWithLimit : MonoBehaviour, IHaveHealth
    {
        [SerializeField] int minValue; 
        [SerializeField] int maxValue; 
        [SerializeField] int currentHealth;
        public int Health { get { return currentHealth; } set { currentHealth = value; } } 
     
        [SerializeField]UnityEvent onHealthChanged;
        public UnityEvent OnHealthChanged => onHealthChanged;

        [SerializeField]UnityEvent onHealthBelowZero;
        public UnityEvent OnHealthBelowZero => onHealthBelowZero;

        void Awake()
        {
            SetHealth(maxValue);
        }

        public void ModifyHealth(int value)
        {
            SetHealth(Health + value);
        }

        public void SetHealth(int health)
        {
            var oldValue = Health;
            Health = Mathf.Clamp(health,minValue,maxValue);
            if(oldValue!= Health)
                OnHealthChanged?.Invoke();
            if (Health<=0)
                OnHealthBelowZero?.Invoke();
        }

    }
}
