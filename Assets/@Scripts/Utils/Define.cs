using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{


    public enum CreatureState
    {
        Idle,
        Skill,
        Moving,
        OnDamaged,
        Dead
    }
    public enum Scene
    {
        Unknown,
        TitleScene,
        LobbyScene,
        GameScene,
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max,
    }

    public enum ObjectType
    {
        Player,
        Monster,
    }

}
