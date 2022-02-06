using UnityEngine;
using UnityEngine.Events;

namespace PoolSystem
{
    public class PoolObject : MonoBehaviour, IPoolObject
    {
        public IPool Pool { get; set; }
        public PoolObjectState PoolObjectState { get; set; }
        [SerializeField]UnityEvent onObjectCreated;
        public Transform Transform => transform;
        public UnityEvent OnObjectCreated => onObjectCreated;

        [SerializeField] UnityEvent onObjectTaken;
        public UnityEvent OnObjectTaken => onObjectTaken;

        [SerializeField] UnityEvent onObjectReturn;
        public UnityEvent OnObjectReturn => onObjectReturn;


        public IPoolObject CreateObject()
        {
            var poolObject= Instantiate(gameObject).GetComponent<IPoolObject>();
            onObjectCreated?.Invoke();
            PoolObjectState = PoolObjectState.Created;
            return poolObject;
        }

        public void OnTakenFromPool()
        {
            PoolObjectState = PoolObjectState.TakenFromPool;
            OnObjectTaken?.Invoke();
        }

        public void OnReturnToPool()
        {
            PoolObjectState = PoolObjectState.ReturnToPool;
            OnObjectReturn?.Invoke();
        }

        [ContextMenu("Return To Pool")]
        public void ReturnToPool()
        {
            Pool.ReturnToPool(this);
        }
    }
}