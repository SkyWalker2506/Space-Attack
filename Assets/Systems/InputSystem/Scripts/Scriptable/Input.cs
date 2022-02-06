using UnityEngine;
using UnityEngine.Events;

namespace InputSystem
{
    public class Input : IInput
    {
        UnityEvent onInputCalled = new UnityEvent();
        public UnityEvent OnInputCalled => onInputCalled;

        public void CallInput()
        {
            OnInputCalled?.Invoke();
        }
    }
}