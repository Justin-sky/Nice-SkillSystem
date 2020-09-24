using UnityEngine;
using System.Collections;

//近身释放器
public class MeleeSkillDeployer : SkillDeployer
{
    public override void DeploySkill()
    {
        CalculateTargets();
    }
}
