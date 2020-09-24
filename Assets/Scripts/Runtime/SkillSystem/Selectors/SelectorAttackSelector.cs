using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectorAttackSelector : IAttackSelector
{
    public Transform[] SelectTarget(SkillData data, Transform skillTF)
    {
        List<Transform> targets = new List<Transform>();
        for (int i = 0; i < data.attackTargetTags.Length; i++) { 

            GameObject[] tempGoArray = GameObject.FindGameObjectsWithTag(data.attackTargetTags[i]);
            targets.AddRange(tempGoArray.Select(g => g.transform));
         }

        targets = targets.FindAll(t =>
             Vector3.Distance(t.position, skillTF.position) <= data.attackDistance &&
             Vector3.Angle(skillTF.forward, t.position-skillTF.position)<= data.attackAngle/2
        );

        targets.FindAll(t => t.GetComponent<CharacterStatus>().HP > 0);

        if(data.attackType == SkillAttackType.Group)
        {
            return targets.ToArray();
        }

        Transform min = targets[0];
        return new Transform[] { min };
    }
}
