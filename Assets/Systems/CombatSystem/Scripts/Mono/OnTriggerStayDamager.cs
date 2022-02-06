using UnityEngine;

namespace CombatSystem
{
    public class OnTriggerStayDamager : DamagerBase
    {
        private void OnTriggerStay(Collider other)
        {
            TryApplyDamage(other.gameObject);
        }
    }

}