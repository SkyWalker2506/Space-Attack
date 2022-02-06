using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem
{
    public static class CombatUtility 
    {
        public static Dictionary<GameObject, IDamagable> DamagableDictionary=new Dictionary<GameObject, IDamagable>();

        public static bool IsDamagable(this GameObject damagableObj)
        {
            return DamagableDictionary.ContainsKey(damagableObj);
        }

        public static IDamagable GetDamagable(this GameObject damagableObj)
        {
            return DamagableDictionary[damagableObj];
        }
    }
}
