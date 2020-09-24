using UnityEngine;
using System.Collections;

//影响效果： 伤害生命  降低防御力  眩晕  减速
public interface IImpactEffect
{

    void Execute(SkillDeployer deployer);

}