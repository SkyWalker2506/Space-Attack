using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PoolSystem
{
    public class Pool : MonoBehaviour,IPool
    {

        [SerializeField] int maxObjectCount;

        [SerializeField] int initialObjectCount;

        [SerializeField] PoolObject poolObject;

        public IPoolObject PoolObjectPrefab => poolObject;

        int totalObjectCount { get { return ActivePoolObjects.Count+ DeActivePoolObjects.Count; } }

        public List<IPoolObject> ActivePoolObjects { get; }

        public List<IPoolObject> DeActivePoolObjects { get; }

        public void InitializeThePool()
        {
            for (int i = 0; i < initialObjectCount; i++)
            {
                CreatePoolObject();
            }
        }

        void CreatePoolObject()
        {
            if (totalObjectCount >= maxObjectCount) return;
            poolObject.CreateObject();
        }

        public void ReturnToPool(IPoolObject poolObject)
        {
            poolObject.ReturnToPool();
            ActivePoolObjects.Remove(poolObject);
            DeActivePoolObjects.Add(poolObject);
        }

    }

    public interface IPool
    {
        IPoolObject PoolObjectPrefab { get; }
        List<IPoolObject> ActivePoolObjects { get; }
        List<IPoolObject> DeActivePoolObjects { get; }

        void InitializeThePool();

    }

    public class PoolObject : MonoBehaviour, IPoolObject
    {
        public IPool Pool { get; }
        UnityEvent onObjectCreated;
        public UnityEvent OnObjectCreated => onObjectCreated;

        UnityEvent onObjectTaken;
        public UnityEvent OnObjectTaken => onObjectTaken;

        UnityEvent onObjectReturn;
        public UnityEvent OnObjectReturn => onObjectReturn;


        public IPoolObject CreateObject()
        {
            var poolObject= Instantiate(gameObject).GetComponent<IPoolObject>();
            onObjectCreated?.Invoke();
            return poolObject;
        }

        public void TakeFromPool()
        {
            OnObjectTaken?.Invoke();
        }

        public void ReturnToPool()
        {
            OnObjectReturn?.Invoke();
        }
    }
}