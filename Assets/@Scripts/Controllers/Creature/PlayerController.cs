using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CreatureController
{
    public int KillCount
    {
        get { return Managers.Game.ContinueInfo.KillCount; }
        set
        {
            Managers.Game.ContinueInfo.KillCount = value;
            //if (Managers.Game.DicMission.TryGetValue(MissionTarget.MonsterKill, out MissionInfo mission))
            //    mission.Progress = value;
            //if (Managers.Game.ContinueInfo.KillCount % 500 == 0)
            //{
            //    Skills.OnMonsterKillBonus();
            //}
            //OnPlayerDataUpdated?.Invoke();
        }
    }
}
