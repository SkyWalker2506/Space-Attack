using UnityEngine;

namespace AbilitySystem
{
    public class ScriptableAbilityListener : AbilityListenerBase
    {
        [SerializeField] ScriptableAbility scriptableAbility;
        public override IAbility Ability => scriptableAbility;
    }

}