using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public interface ICanDamage
    {
        UnityEvent OnApplyDamage { get; }
        int Damage { get; }

        void SetDamage(int damage);
        void ApplyDamage();

    }
}