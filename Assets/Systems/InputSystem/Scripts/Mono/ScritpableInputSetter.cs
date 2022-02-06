using UnityEngine;

namespace InputSystem
{
    public class ScritpableInputSetter : InputSetterBase
    {
        [SerializeField] ScriptableInput scritpableInput;
        public override IInput Input => scritpableInput;
    }
}