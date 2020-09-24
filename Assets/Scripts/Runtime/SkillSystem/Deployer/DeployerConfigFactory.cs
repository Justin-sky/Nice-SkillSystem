using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;

public class DeployerConfigFactory
{
    private static Dictionary<string, object> cache;

    static DeployerConfigFactory()
    {
        cache = new Dictionary<string, object>();
    }

    public static IAttackSelector CreateAttackSelector(SkillData data)
    {
        string className = string.Format("{0}AttackSelector", data.selectorType);
        return CreateObject<IAttackSelector>(className);
    }

    public static IImpactEffect[] CreateImpactEffects(SkillData data)
    {
        IImpactEffect[] impacts = new IImpactEffect[data.impactType.Length];

        for(int i=0; i<data.impactType.Length; i++)
        {
            string classNameImpact = string.Format("{0}Impact", data.impactType[i]);
            impacts[i] = CreateObject<IImpactEffect>(classNameImpact);
        }
        return impacts;
    }

    private static T CreateObject<T>(string className) where T:class
    {
        if (!cache.ContainsKey(className))
        {
            Type type = Type.GetType(className);
            object instance = Activator.CreateInstance(type);
            cache.Add(className, instance);
        }

        return cache[className] as T;
    }
}