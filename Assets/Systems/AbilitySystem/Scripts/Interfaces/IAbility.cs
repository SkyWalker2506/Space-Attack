using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

namespace AbilitySystem
{
    public interface IAbility 
    {
        bool IsAbilityActive { get; }
        float ActiveTime { get; }
        Cooldown Cooldown { get; }
        UnityEvent OnAbilityActivated { get; }
        UnityEvent OnAbilityDeactivated { get; }
        void ActivateAbility();
        void DeactivateAbility();
    }

}
