using System.Collections.Generic;
using UnityEngine;

namespace PoolSystem
{
    public class Pool : MonoBehaviour,IPool
    {

        [SerializeField] int maxObjectCount;

        [SerializeField] int initialObjectCount;

        [SerializeField] PoolObject poolObjectPrefab;

        public IPoolObject PoolObjectPrefab => poolObjectPrefab;

        int totalObjectCount { get { return ActivePoolObjects.Count+ DeactivePoolObjects.Count; } }

        public List<IPoolObject> ActivePoolObjects { get; private set; }

        public List<IPoolObject> DeactivePoolObjects { get; private set; }


        private void Awake()
        {
            InitializeThePool();
        }

        public void InitializeThePool()
        {
            ActivePoolObjects = new List<IPoolObject>();
            DeactivePoolObjects = new List<IPoolObject>();
            for (int i = 0; i < initialObjectCount; i++)
            {
                CreatePoolObject();
            }
        }

        [ContextMenu("Create Pool Object")]
        void CreatePoolObject()
        {
            if (totalObjectCount >= maxObjectCount)
            {
                Debug.Log("Pool reached the max object capacity");
                return;
            }
            var poolObject=poolObjectPrefab.CreateObject();
            poolObject.Pool = this;
            poolObject.Transform.parent = transform;
            DeactivePoolObjects.Add(poolObject);
        }

        public void ReturnToPool(IPoolObject poolObject)
        {
            poolObject.OnReturnToPool();
            ActivePoolObjects.Remove(poolObject);
            DeactivePoolObjects.Add(poolObject);
            poolObject.Transform.parent = transform;
        }

        [ContextMenu("Take From Pool")]
        public IPoolObject TakeFromPool()
        {
            if (DeactivePoolObjects.Count == 0)
                CreatePoolObject();
            var poolObject = DeactivePoolObjects[0];
            DeactivePoolObjects.Remove(poolObject);
            ActivePoolObjects.Add(poolObject);
            poolObject.OnTakeFromPool();
            poolObject.Transform.parent = null;
            return poolObject;
        }
    }
}