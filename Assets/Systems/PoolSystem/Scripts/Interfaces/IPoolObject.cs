using UnityEngine;
using UnityEngine.Events;

namespace PoolSystem
{
    public interface IPoolObject
    {
        IPool Pool { get; set; }
        Transform Transform { get; }
        UnityEvent OnObjectCreated { get; }
        UnityEvent OnObjectTaken { get; }
        UnityEvent OnObjectReturn { get; }
        IPoolObject CreateObject();
        void OnTakeFromPool();
        void OnReturnToPool();
        void ReturnToPool();
    }
}