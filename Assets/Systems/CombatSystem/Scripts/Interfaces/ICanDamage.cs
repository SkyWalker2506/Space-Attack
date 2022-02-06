using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public interface ICanDamage
    {
        UnityEvent<int> OnApplyDamage { get; }
        int Damage { get; }

        void SetDamage(int damage);
        void TryApplyDamage(GameObject damagable);
        void ApplyDamage(IDamagable damagable);
    }

}