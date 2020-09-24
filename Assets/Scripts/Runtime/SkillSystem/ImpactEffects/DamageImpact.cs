using UnityEngine;
using System.Collections;

public class DamageImpact : IImpactEffect
{

    public void Execute(SkillDeployer deployer)
    {
        deployer.StartCoroutine(RepeatDamage(deployer));
    }

    //多次伤害
    private IEnumerator RepeatDamage(SkillDeployer deployer)
    {
        float atkTime = 0;
        do
        {
            //伤害生命
            OnceDamage(deployer.SkillData);

            yield return new WaitForSeconds(deployer.SkillData.atkInterval);
            atkTime += deployer.SkillData.atkInterval;
            deployer.CalculateTargets(); //重新计算目标

        } while (atkTime < deployer.SkillData.durationTime);
        
    }

    private void OnceDamage(SkillData data)
    {
        float atk = data.atkRatio * data.owner.GetComponent<CharacterStatus>().baseATK;
        for(int i=0; i<data.attakcTargets.Length; i++)
        {
            var status = data.attakcTargets[i].GetComponent<CharacterStatus>();
            status.Damage(atk);
        }
    }
}
