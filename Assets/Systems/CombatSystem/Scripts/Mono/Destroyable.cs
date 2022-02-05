using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public class Destroyable : MonoBehaviour, IDestroyable
    {
        [SerializeField] UnityEvent onDestroyed;
        public UnityEvent OnDestroyed => onDestroyed;

        public void GetDestroyed()
        {
            OnDestroyed?.Invoke();
            throw new System.NotImplementedException();
        }
    }
}
