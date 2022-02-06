using UnityEngine;

namespace InputSystem
{
    public class ScritpableKeyInputCaller : KeyInputCallerBase
    {
        [SerializeField] ScriptableInput input;
        public override IInput Input => input;


    }
}