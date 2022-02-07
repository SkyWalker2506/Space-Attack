using UnityEngine;
using UnityEngine.Events;

namespace AbilitySystem
{
    public abstract class AbilityListenerBase :MonoBehaviour,IAbilityListener
    {
        public abstract IAbility Ability { get; }

        [SerializeField] UnityEvent onAbilityActivated;
        public UnityEvent OnAbilityActivated => onAbilityActivated;

        [SerializeField] UnityEvent onAbilityDeactivated;
        public UnityEvent OnAbilityDeactivated => onAbilityDeactivated;


        private void OnEnable()
        {
            Ability.OnAbilityActivated.AddListener(OnAbilityActivated.Invoke);
            Ability.OnAbilityDeactivated.AddListener(OnAbilityDeactivated.Invoke);
        }

        private void OnDisable()
        {
            Ability.OnAbilityActivated.AddListener(OnAbilityActivated.Invoke);
            Ability.OnAbilityDeactivated.AddListener(OnAbilityDeactivated.Invoke);
        }
    }

}