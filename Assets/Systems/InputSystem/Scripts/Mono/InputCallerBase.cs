using UnityEngine;

namespace InputSystem
{
    public abstract class InputCallerBase : MonoBehaviour, IInputCaller
    {
        public abstract IInput Input { get; }

        public virtual void CallInput()
        {
            Input.CallInput();
        }
    }
}