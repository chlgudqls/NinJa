using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// 계정에관한 모든 정보 
[Serializable]
public class GameData
{
    public int UserLevel = 1;
    public string UserName = "Player";

    //public int Stamina = Define.MAX_STAMINA;
    public int Gold = 0;
    public int Dia = 0;

    #region 업적
    public int CommonGachaOpenCount = 0;
    public int AdvancedGachaOpenCount = 0;
    public int FastRewardCount = 0;
    public int OfflineRewardCount = 0;
    public int TotalMonsterKillCount = 0;
    public int TotalEliteKillCount = 0;
    public int TotalBossKillCount = 0;
    //public List<Data.AchievementData> Achievements = new List<AchievementData>();  // 업적 목록

    #endregion

    #region 하루마다 초기화
    public int GachaCountAdsAnvanced = 1;
    public int GachaCountAdsCommon = 1;
    public int GoldCountAds = 1;
    public int RebirthCountAds = 3;
    public int DiaCountAds = 3;
    public int StaminaCountAds = 1;
    public int FastRewardCountAds = 1;
    public int FastRewardCountStamina = 3;
    public int SkillRefreshCountAds = 3;
    public int RemainsStaminaByDia = 3;
    public int BronzeKeyCountAds = 1;
    #endregion

    public bool[] AttendanceReceived = new bool[30];
    public bool BGMOn = true;
    public bool EffectSoundOn = true;
    //public Define.JoystickType JoystickType = Define.JoystickType.Flexible;
    //public List<Character> Characters = new List<Character>();
    //public List<Equipment> OwnedEquipments = new List<Equipment>();
    public ContinueData ContinueInfo = new ContinueData();
    //public StageData CurrentStage = new StageData();
    //public Dictionary<int, int> ItemDictionary = new Dictionary<int, int>();//<ID, 갯수>
    //public Dictionary<EquipmentType, Equipment> EquippedEquipments = new Dictionary<EquipmentType, Equipment>();
    //public Dictionary<int, StageClearInfo> DicStageClearInfo = new Dictionary<int, StageClearInfo>();
    //public Dictionary<MissionTarget, MissionInfo> DicMission = new Dictionary<MissionTarget, MissionInfo>()
    //{
    //    {MissionTarget.StageEnter, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.StageClear, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.EquipmentLevelUp, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.OfflineRewardGet, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.EquipmentMerge, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.MonsterKill, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.EliteMonsterKill, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.GachaOpen, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //    {MissionTarget.ADWatchIng, new MissionInfo() { Progress = 0, IsRewarded = false }},
    //};
}
public class GameManager
{
    public GameData _gameData = new GameData();

    public PlayerController Player { get; set; }

    public ContinueData ContinueInfo
    {
        get { return _gameData.ContinueInfo; }
        set
        {
            _gameData.ContinueInfo = value;
        }
    }


}

[Serializable]
public class ContinueData
{
    public int PlayerDataId;
    public float Hp;
    public float MaxHp;
    public float MaxHpBonusRate = 1;
    public float HealBonusRate = 1;
    public float HpRegen;
    public float Atk;
    public float AttackRate = 1;
    public float Def;
    public float DefRate;
    public float MoveSpeed;
    public float MoveSpeedRate = 1;
    public float TotalExp;
    public int Level = 1;
    public float Exp;
    public float CriRate;
    public float CriDamage = 1.5f;
    public float DamageReduction;
    public float ExpBonusRate = 1;
    public float SoulBonusRate = 1;
    public float CollectDistBonus = 1;
    public int KillCount;
    public int SkillRefreshCount = 3;
    public float SoulCount;


    public int WaveIndex;
    public void Clear()
    {
        // 각 변수의 초기값 설정
        PlayerDataId = 0;
        Hp = 0f;
        MaxHp = 0f;
        MaxHpBonusRate = 1f;
        HealBonusRate = 1f;
        HpRegen = 0f;
        Atk = 0f;
        AttackRate = 1f;
        Def = 0f;
        DefRate = 0f;
        MoveSpeed = 0f;
        MoveSpeedRate = 1f;
        TotalExp = 0f;
        Level = 1;
        Exp = 0f;
        CriRate = 0f;
        CriDamage = 1.5f;
        DamageReduction = 0f;
        ExpBonusRate = 1f;
        SoulBonusRate = 1f;
        CollectDistBonus = 1f;

        KillCount = 0;
        SoulCount = 0f;
        SkillRefreshCount = 3;


    }
}
