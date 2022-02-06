using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public abstract class DamagerBase : MonoBehaviour, ICanDamage
    {
        [SerializeField] UnityEvent<int> onApplyDamage;
        public UnityEvent<int> OnApplyDamage => onApplyDamage;

        [SerializeField] int damage;
        public int Damage { get {return damage; }set { damage = value; }}

        public void TryApplyDamage(GameObject damagable)
        {
            if (damagable.IsDamagable())
                ApplyDamage(damagable.GetDamagable());
        }

        public virtual void ApplyDamage(IDamagable damagable)
        {
            damagable.Damage(damage);
            OnApplyDamage?.Invoke(Damage);
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }
    }
}