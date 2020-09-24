using UnityEngine;
using System.Collections;

//选区 矩形  扇形 三角形
public interface IAttackSelector
{
    Transform[] SelectTarget(SkillData data, Transform skillTF);
}
