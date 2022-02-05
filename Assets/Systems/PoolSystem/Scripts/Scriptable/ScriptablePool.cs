using UnityEngine;

namespace PoolSystem
{
    [CreateAssetMenu(menuName = "PoolSystem/ScriptablePool")]
    public class ScriptablePool : ScriptableObject
    {
        public Pool Pool;
    }
}