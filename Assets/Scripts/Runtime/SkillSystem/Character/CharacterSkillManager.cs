using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;
using System;

public class CharacterSkillManager : MonoBehaviour
{

    public SkillData[] skills;

    private void Start()
    {
        for(int i=0; i< skills.Length; i++)
        {
            InitSkill(skills[i]);
        }
    }

    private void InitSkill(SkillData data)
    {
        data.skillPrefab = Resources.Load<GameObject>(data.prefabName);
        data.owner = gameObject;

    }

    public SkillData PrepareSkill(int id)
    {
        SkillData data = Find(s => s.skillID == id);

        float sp = GetComponent<CharacterStatus>().SP;
        if(data != null && data.coolRemain <=0 && data.costSP <= sp)
        {
            return data;
        }

        return null;
    }

    private SkillData Find(Func<SkillData, bool> handler)
    {
        for(int i=0; i<skills.Length; i++)
        {
            if (handler(skills[i])) return skills[i];
        }
        return null;
    }

    public void GenerateSkill(SkillData data)
    {
        GameObject skillGo = Instantiate(data.skillPrefab, transform.position, transform.rotation);
        SkillDeployer deployer = skillGo.GetComponent<SkillDeployer>();

        deployer.SkillData = data;
        deployer.DeploySkill();


        //回收对象
        Destroy(skillGo, data.durationTime);

        StartCoroutine(CoolTimeDown(data));
        //GameObjectPool.Instance.CollectObject(skillGo, data.durationTime);
    }

    private IEnumerator CoolTimeDown(SkillData data)
    {
        data.coolRemain = data.coolTime;
        while(data.coolRemain > 0)
        {
            yield return new WaitForSeconds(1);
            data.coolRemain--;
        }
        
    }
}
