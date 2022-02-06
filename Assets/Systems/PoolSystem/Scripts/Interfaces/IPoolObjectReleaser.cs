namespace PoolSystem
{
    public interface IPoolObjectReleaser
    {
        IPoolObject PoolObject { get; }
        void ReleasePoolObject();
    }

}