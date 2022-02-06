namespace InputSystem
{
    public interface IInputCaller
    {
        IInput Input { get; }
        void CallInput();
    }
}