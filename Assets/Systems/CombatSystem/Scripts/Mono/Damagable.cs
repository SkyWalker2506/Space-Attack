using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class Damagable : MonoBehaviour, IDamagable
    {
        [SerializeField]
        UnityEvent<int> onDamaged;
        public UnityEvent<int> OnDamaged => onDamaged;
    }
}
