using UnityEngine;
using UnityEngine.Events;

namespace PoolSystem
{
    public interface IPoolObject
    {
        IPool Pool { get; set; }
        PoolObjectState PoolObjectState { get; set; }
        Transform Transform { get; }
        UnityEvent OnObjectCreated { get; }
        UnityEvent OnObjectTaken { get; }
        UnityEvent OnObjectReturn { get; }
        IPoolObject CreateObject();
        void OnTakenFromPool();
        void OnReturnToPool();
        void ReturnToPool();
    }
}