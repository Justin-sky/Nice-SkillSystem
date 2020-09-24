using UnityEngine;
using System.Collections;

//释放器  近身释放 远程释放  跟随释放
public abstract class SkillDeployer : MonoBehaviour
{

    private SkillData skillData;

    public SkillData SkillData { get; set; }

    private IAttackSelector selector;  //选区
    private IImpactEffect[] impactArray; //影响

    private void InitDeployer()
    {
        selector = DeployerConfigFactory.CreateAttackSelector(skillData);

        impactArray = DeployerConfigFactory.CreateImpactEffects(skillData);

    }

    public void CalculateTargets()
    {
       skillData.attakcTargets =  selector.SelectTarget(skillData, transform);
    }


    public void ImpactTargets()
    {
        for(int i=0; i< impactArray.Length; i++)
        {
            impactArray[i].Execute(this);
        }
    }
    public abstract void DeploySkill();
}
