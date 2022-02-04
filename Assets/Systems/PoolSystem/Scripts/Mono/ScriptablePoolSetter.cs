using UnityEngine;

namespace PoolSystem
{
    public class ScriptablePoolSetter : MonoBehaviour
    {
        [SerializeField] Pool pool;
        [SerializeField] ScriptablePool scriptablePool;

        private void Awake()
        {
            scriptablePool.Pool = pool;
        }
    }
}