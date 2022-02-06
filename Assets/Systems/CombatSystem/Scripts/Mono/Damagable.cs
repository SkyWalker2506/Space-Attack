using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class Damagable : MonoBehaviour, IDamagable
    {
        [SerializeField]
        UnityEvent<int> onDamaged;
        public UnityEvent<int> OnDamaged => onDamaged;

        private void Awake()
        {
            CombatUtility.DamagableDictionary.Add(gameObject, this);
        }

        public void Damage(int value)
        {
            OnDamaged?.Invoke(value);
        }
    }
}
