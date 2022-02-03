using UnityEngine.Events;

namespace CombatSystem
{
    public interface IDestroyable
    {
        UnityEvent OnDestroyed { get; }

        void GetDestroyed();
    }
}