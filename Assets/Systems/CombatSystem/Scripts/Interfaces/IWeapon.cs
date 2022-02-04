using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public interface IWeapon  
    {
        UnityEvent OnAttack { get; }
        void Attack();
    }
}
