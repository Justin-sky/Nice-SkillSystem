using UnityEngine;
using System.Collections;

public class CharacterInputController : MonoBehaviour
{
    private CharacterSkillSystem skillSystem;
    private Animator anim;
    private void Awake()
    {
        skillSystem = GetComponent<CharacterSkillSystem>();
    }

    private float lastPressTime = -1;
    private void OnSkillButtonDown()
    {
        //正在攻击 ，退出
        if (IsAttacking()) return;

        //按住间隔小于2则取消攻击 
        //间隔小于5秒视为连击
        float interval = Time.time-lastPressTime;
        if (interval < 2) return;

        //连击
        bool isBatter = interval <= 5;

        int id = 100;
        skillSystem.AttackUseSkill(id, isBatter);

        lastPressTime = Time.time;
    }

    private bool IsAttacking()
    {
        return anim.GetBool("attack01") || anim.GetBool("attack02");
    }
}
