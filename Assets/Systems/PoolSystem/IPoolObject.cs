using UnityEngine.Events;

namespace PoolSystem
{
    public interface IPoolObject
    {
        IPool Pool { get; }
        UnityEvent OnObjectCreated { get; }
        UnityEvent OnObjectTaken { get; }
        UnityEvent OnObjectReturn { get; }
        IPoolObject CreateObject();
        void TakeFromPool();
        void ReturnToPool();
    }
}