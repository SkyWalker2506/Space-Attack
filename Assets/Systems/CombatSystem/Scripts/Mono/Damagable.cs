using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class Damagable : MonoBehaviour, IDamagable
    {
        [SerializeField]
        UnityEvent<int> onDamaged;
        public UnityEvent<int> OnDamaged => onDamaged;

        private void Start()
        {
            CombatUtility.DamagableDictionary.Add(gameObject, this);
        }

        public void Damage(int value)
        {
            if (!enabled) return;
            OnDamaged?.Invoke(value);
        }
    }
}
