using UnityEngine;
using UnityEngine.Events;

namespace PoolSystem
{
    public class PoolObject : MonoBehaviour, IPoolObject
    {
        public IPool Pool { get; set; }
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
            return poolObject;
        }

        public void OnTakeFromPool()
        {
            OnObjectTaken?.Invoke();
        }

        public void OnReturnToPool()
        {
            OnObjectReturn?.Invoke();
        }

        [ContextMenu("Return To Pool")]
        public void ReturnToPool()
        {
            Pool.ReturnToPool(this);
        }
    }
}