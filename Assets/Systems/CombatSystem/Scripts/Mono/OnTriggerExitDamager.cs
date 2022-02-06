using UnityEngine;

namespace CombatSystem
{
    public class OnTriggerExitDamager : DamagerBase
    {
        private void OnTriggerExit(Collider other)
        {
            TryApplyDamage(other.gameObject);
        }
    }

}