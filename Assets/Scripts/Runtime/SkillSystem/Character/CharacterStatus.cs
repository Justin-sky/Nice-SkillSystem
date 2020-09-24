using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour
{
    public float baseATK;
    public float SP; //能量
    public float HP;
    public float attackDistance;
    public float attackInterval;

    public void Damage(float atk)
    {
        HP -= atk;

        if (HP <= 0) Death();
    }

    protected virtual void Death()
    {
        //播放死亡动画
    }
}
