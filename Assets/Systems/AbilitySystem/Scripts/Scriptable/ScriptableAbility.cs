using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace AbilitySystem
{
    [CreateAssetMenu(menuName = "AbilitySystem/ScriptableAbility")]
    public class ScriptableAbility : ScriptableObject, IAbility
    {
        [SerializeField] bool isAbilityActive;
        public bool IsAbilityActive { get { return isAbilityActive; } set { isAbilityActive=value; } }
        [SerializeField] UnityEvent onAbilityActivated;
        public UnityEvent OnAbilityActivated => onAbilityActivated;

        [SerializeField] UnityEvent onAbilityDeactivated;
        public UnityEvent OnAbilityDeactivated => onAbilityDeactivated;

        [SerializeField] float activeTime;
        public float ActiveTime => activeTime;

        [SerializeField] Cooldown cooldown;
        public Cooldown Cooldown => cooldown;

        public void Initialize()
        {
            IsAbilityActive = false;
            Cooldown.LastCalledTime = -Cooldown.CooldownTime;
        }

        public void ActivateAbility()
        {
            if (IsAbilityActive) return;
            if (!Cooldown.IsCooldownFinished) return;
            IsAbilityActive = true;
            Cooldown.UpdateCooldown();
            OnAbilityActivated?.Invoke();
            MonoHelper.Instance.StartCoroutine(StartDeactivateTimer());
        }

        IEnumerator StartDeactivateTimer()
        {
            yield return new WaitForSecondsRealtime(activeTime);
            DeactivateAbility();
        }

        public void DeactivateAbility()
        {
            if (!IsAbilityActive) return;
            IsAbilityActive = false;
            OnAbilityDeactivated?.Invoke();
        }
    }
}