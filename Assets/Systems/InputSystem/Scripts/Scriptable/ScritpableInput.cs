﻿using UnityEngine;
using UnityEngine.Events;

namespace InputSystem
{
    [CreateAssetMenu(menuName = "InputSystem/ScritpableInput")]
    public class ScritpableInput : ScriptableObject, IInput
    {
        [SerializeField] UnityEvent onInputCalled;
        public UnityEvent OnInputCalled => onInputCalled;

        [ContextMenu("Call Input")]
        public void CallInput()
        {
            OnInputCalled?.Invoke();
        }
    }
}