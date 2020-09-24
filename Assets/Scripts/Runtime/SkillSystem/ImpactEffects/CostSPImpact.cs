using UnityEngine;
using System.Collections;

public class CostSPImpact : IImpactEffect
{
    public void Execute(SkillDeployer deployer)
    {
       var status =  deployer.SkillData.owner.GetComponent<CharacterStatus>();
        status.SP -= deployer.SkillData.costSP;
    }
}
