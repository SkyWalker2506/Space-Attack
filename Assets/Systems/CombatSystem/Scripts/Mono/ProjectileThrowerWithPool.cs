using PoolSystem;
using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class ProjectileThrowerWithPool : MonoBehaviour, IWeapon
    {
        [SerializeField] UnityEvent onAttack;
        public UnityEvent OnAttack => onAttack;
        [SerializeField] ScriptablePool projectilePool;
        [SerializeField] Transform weaponTip;

        [ContextMenu("Attack")]
        public void Attack()
        {
            if (gameObject.activeSelf == false) return;
            onAttack?.Invoke();
            var projectile=projectilePool.Pool.TakeFromPool();
            projectile.Transform.position = weaponTip.position;
            projectile.Transform.rotation = weaponTip.rotation;
        }
    }


}