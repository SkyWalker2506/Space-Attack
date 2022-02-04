using PoolSystem;
using UnityEngine;

namespace CombatSystem
{
    public class ProjectileThrowerWithPool : MonoBehaviour, IWeapon
    {
        [SerializeField] Pool projectilePool;
        public void Attack()
        {

        }
    }


}