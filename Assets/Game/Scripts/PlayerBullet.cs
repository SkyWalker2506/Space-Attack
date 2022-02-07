using AbilitySystem;
using CombatSystem;
using UnityEngine;

public class PlayerBullet : Bullet
{
    Damagable damagable;

    [SerializeField] ScriptableAbility undestructableBulletAbility;

    protected override void Initialize()
    {
        base.Initialize();
        damagable = GetComponent<Damagable>();
        if (damagable == null)
            Debug.Log("No damagable", gameObject);

        if (undestructableBulletAbility.IsAbilityActive)
            SetDamagableOff();
        else
            SetDamagableOn();
    }

    void OnEnable()
    {
        undestructableBulletAbility.OnAbilityActivated.AddListener(SetDamagableOff);
        undestructableBulletAbility.OnAbilityDeactivated.AddListener(SetDamagableOn);
    }

    void OnDisable()
    {
        undestructableBulletAbility.OnAbilityActivated.RemoveListener(SetDamagableOff);
        undestructableBulletAbility.OnAbilityDeactivated.RemoveListener(SetDamagableOn);
    }

    void SetDamagableOn()
    {
        damagable.enabled = true;
    }

    void SetDamagableOff()
    {
        damagable.enabled = false;
    }

}
