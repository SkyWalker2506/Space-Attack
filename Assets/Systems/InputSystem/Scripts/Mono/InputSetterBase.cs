using UnityEngine;
using UnityEngine.Events;

namespace InputSystem
{

    public class InputSetterBase : MonoBehaviour, IInputSetter
    {
        public virtual IInput Input { get; }

        [SerializeField] UnityEvent<IInput> inputSetterEvent;
        public UnityEvent<IInput> InputSetterEvent => inputSetterEvent;

        void Start()
        {
            SetInput();
        }

        protected virtual void SetInput()
        {
            if (Input != null)
                InputSetterEvent?.Invoke(Input);
        }
    }
}