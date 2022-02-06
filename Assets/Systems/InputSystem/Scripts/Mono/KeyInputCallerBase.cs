using UnityEngine;

namespace InputSystem
{
    public abstract class KeyInputCallerBase : InputCallerBase
    {
        [SerializeField] KeyCode keyCode;
        [SerializeField] bool callOnKeyDown;
        [SerializeField] bool callOnKeyHold;
        [SerializeField] bool callOnKeyUp;

        private void Update()
        {
            if (callOnKeyDown&&UnityEngine.Input.GetKeyDown(keyCode))
                CallInput();
            if (callOnKeyHold && UnityEngine.Input.GetKey(keyCode))
                CallInput();
            if (callOnKeyUp && UnityEngine.Input.GetKeyUp(keyCode))
                CallInput();
        }
    }
}