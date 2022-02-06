using UnityEngine.Events;

namespace InputSystem
{
    public static class InputUtility 
    {
        public static void SetInput(IInput inputToSet, IInput input, UnityAction action)
        {
            if (inputToSet != null)
                inputToSet.OnInputCalled.RemoveListener(action);
            inputToSet = input;
            if (inputToSet != null)
                inputToSet.OnInputCalled.AddListener(action);
        }
    }
}
