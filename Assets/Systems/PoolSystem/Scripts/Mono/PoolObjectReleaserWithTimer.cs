using UnityEngine;

namespace PoolSystem
{
    public class PoolObjectReleaserWithTimer : PoolObjectReleaserBase
    {
        [SerializeField]float releaseTime = 10;

        private void Start()
        {
            CancelInvoke();
            if(PoolObject!=null&&PoolObject.PoolObjectState==PoolObjectState.TakenFromPool)
               OnObjectTaken();
        }

        public override void OnObjectTaken()
        {
            Invoke(nameof(ReleasePoolObject), releaseTime);
        }
    }

}