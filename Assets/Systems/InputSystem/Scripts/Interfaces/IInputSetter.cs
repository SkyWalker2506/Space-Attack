using UnityEngine.Events;

namespace InputSystem
{

    public interface IInputSetter
    {
        IInput Input { get; }
        UnityEvent<IInput> InputSetterEvent { get; }
    }
}