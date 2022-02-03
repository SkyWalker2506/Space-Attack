using UnityEngine.Events;

namespace CombatSystem
{
    public interface IDamagable
    {
        UnityEvent<int> OnDamaged { get; }
    }
}

