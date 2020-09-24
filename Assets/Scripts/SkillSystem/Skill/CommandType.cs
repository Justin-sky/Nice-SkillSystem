namespace SkillSystem
{
    public enum CommandType
    {
        [Descriptor("无操作")]
        None = 0,

        [Descriptor("点击")]
        Click = 10,

        [Descriptor("上")]
        Up = 11,

        [Descriptor("下")]
        Down = 12,

        [Descriptor("左")]
        Left = 13,

        [Descriptor("防御")]
        Defend = 14
    }
}
