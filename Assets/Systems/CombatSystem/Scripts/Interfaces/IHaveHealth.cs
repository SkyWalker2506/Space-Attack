using UnityEngine.Events;

namespace CombatSystem
{
    public interface IHaveHealth
    {
        UnityEvent OnHealthChanged { get; }
        UnityEvent OnHealthBelowZero { get; }

        int Health { get; }

        void SetHealth(int health);
        void ModifyHealth(int value);

    }
}

