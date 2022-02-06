using UnityEngine;

namespace PoolSystem
{
    public abstract class PoolObjectReleaserBase : MonoBehaviour, IPoolObjectReleaser
    {
        public IPoolObject PoolObject { get; protected set; }

        private void Awake()
        {
            PoolObject = GetComponent<IPoolObject>();
            PoolObject.OnObjectTaken.AddListener(OnObjectTaken);
        }

        private void OnDestroy()
        {
            PoolObject.OnObjectTaken.RemoveListener(OnObjectTaken);
        }

        public virtual void OnObjectTaken(){}

        public virtual void ReleasePoolObject()
        {
            if(PoolObject.PoolObjectState == PoolObjectState.TakenFromPool)
               PoolObject.ReturnToPool();
        }
    }

}