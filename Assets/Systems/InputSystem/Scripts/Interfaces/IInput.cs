using UnityEngine.Events;

namespace InputSystem
{
    public interface IInput  
    {
        UnityEvent OnInputCalled { get; }
    }
}