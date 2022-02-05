using UnityEngine;

namespace InputSystem
{
    public class ScritpableInputSetter : InputSetterBase
    {
        [SerializeField] ScritpableInput scritpableInput;
        public override IInput Input => scritpableInput;
    }
}