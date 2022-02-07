using System;
using UnityEngine;

[Serializable]
public class Cooldown 
{
    public float LastCalledTime;
    [Min(0)] public float CooldownTime;
    public float LeftTime { get { return Mathf.Max(0, CooldownTime - PassedTime); } }
    public float PassedTime { get { return Time.realtimeSinceStartup- LastCalledTime; } }
    public bool IsCooldownFinished { get { return LeftTime <= 0; } }


    public Cooldown(float time)
    {
        CooldownTime = time;
        UpdateCooldown();
    }

    public void UpdateCooldown()
    {
        LastCalledTime = Time.realtimeSinceStartup;
    }

}
