using UnityEngine.Events;

namespace AbilitySystem
{
    public interface IAbilityListener
    {
        IAbility Ability { get; }
        UnityEvent OnAbilityActivated { get; }
        UnityEvent OnAbilityDeactivated { get; }

    }
}
