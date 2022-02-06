using UnityEngine;

namespace CombatSystem
{
    public class OnTriggerEnterDamager : DamagerBase
    {
        private void OnTriggerEnter(Collider other)
        {
            TryApplyDamage(other.gameObject);
        }
    }

}