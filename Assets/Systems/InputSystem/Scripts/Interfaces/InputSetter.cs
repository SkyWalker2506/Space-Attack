using UnityEngine.Events;

namespace InputSystem
{
    public interface InputSetter
    {
        IInput Input { get; }
        UnityEvent<IInput> InputSetterEvent { get; }
    }
}