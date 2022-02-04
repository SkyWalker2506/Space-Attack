using System.Collections.Generic;

namespace PoolSystem
{
    public interface IPool
    {
        IPoolObject PoolObjectPrefab { get; }
        List<IPoolObject> ActivePoolObjects { get; }
        List<IPoolObject> DeactivePoolObjects { get; }

        void InitializeThePool();
        IPoolObject TakeFromPool();
        void ReturnToPool(IPoolObject poolObject);
    }
}