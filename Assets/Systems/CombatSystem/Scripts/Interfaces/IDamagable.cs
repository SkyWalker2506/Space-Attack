using UnityEngine.Events;

namespace CombatSystem
{
    public interface IDamagable
    {
        UnityEvent OnDamaged { get; }

    }
}

