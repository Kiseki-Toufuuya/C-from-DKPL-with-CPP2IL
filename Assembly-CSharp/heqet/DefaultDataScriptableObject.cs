namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/DefaultDataScriptableObject")]
public class DefaultDataScriptableObject : ScriptableObject, IJsonImportExport
{
	internal class Data
	{
		public int money; //Field offset: 0x8
		public Int32[] heroineIds; //Field offset: 0xC
		public Int32[] mitamaIds; //Field offset: 0x10
		public Int32[] musicIds; //Field offset: 0x14
		public int formation_main; //Field offset: 0x18
		public int formation_sub; //Field offset: 0x1C
		public int formation_mitama; //Field offset: 0x20
		[Header("カグラ設定")]
		public int kaguraSpeedType; //Field offset: 0x24
		public int kaguraSpeedLevel; //Field offset: 0x28
		public int kaguraSpeedLevelAuto; //Field offset: 0x2C
		public int kaguraSpeedCountupBpm; //Field offset: 0x30
		public int kaguraSpeedBaseBpm; //Field offset: 0x34
		public float kaguraSpeed; //Field offset: 0x38
		public bool kaguraEnableSudden; //Field offset: 0x3C
		public float kaguraShudden; //Field offset: 0x40
		public bool kaguraEnableHidden; //Field offset: 0x44
		public float kaguraHidden; //Field offset: 0x48
		public bool kaguraNotesTap; //Field offset: 0x4C
		public bool kaguraAutoPlay; //Field offset: 0x4D
		public bool kaguraAnimation; //Field offset: 0x4E
		public bool kaguraGuide; //Field offset: 0x4F
		public int kaguraNoteSkin; //Field offset: 0x50
		public int kaguraLaneBrightness; //Field offset: 0x54
		public int kaguraJudgeMessageType; //Field offset: 0x58
		public Vector2 kaguraJudgeMessagePosition; //Field offset: 0x5C
		public int kaguraComboMessageType; //Field offset: 0x64
		public Vector2 kaguraComboMessagePosition; //Field offset: 0x68
		public int kaguraFastSlowMessageType; //Field offset: 0x70
		public int kaguraLayoutType; //Field offset: 0x74
		public bool kaguraEnableRhythmbeat; //Field offset: 0x78
		public bool kaguraEnableNotesConnection; //Field offset: 0x79
		public bool kaguraHighaccuracy; //Field offset: 0x7A
		public bool kaguraTapaccuracy; //Field offset: 0x7B
		public bool kaguraMusicSync; //Field offset: 0x7C
		public bool kaguraBackGroundMovie; //Field offset: 0x7D
		[Header("ダンマク設定")]
		public bool danmakuDispCollision; //Field offset: 0x7E
		public float danmakuPlayerBnulletOpacity; //Field offset: 0x80
		[Header("共通設定")]
		public int commonTapTiming; //Field offset: 0x84
		public int commonMusicTiming; //Field offset: 0x88
		public int commonResolution; //Field offset: 0x8C
		public int commonDisplaymode; //Field offset: 0x90
		public int commonFPS; //Field offset: 0x94
		public float commonAdventureTextSpeed; //Field offset: 0x98
		public float commonNovelTextSpeed; //Field offset: 0x9C
		public bool commonDispPage; //Field offset: 0xA0
		public float commonSystemMusicVolume; //Field offset: 0xA4
		public float commonSystemSeVolume; //Field offset: 0xA8
		public float commonMusicVolume; //Field offset: 0xAC
		public float commonTapSeVolume; //Field offset: 0xB0
		public float commonDanmakuSeVolume; //Field offset: 0xB4
		public bool commonCenterLine; //Field offset: 0xB8
		public uint commonRandomFlag; //Field offset: 0xBC
		public float commonTapTimingRatio; //Field offset: 0xC0
		public float commonMusicTimingRatio; //Field offset: 0xC4
		public int commonMusicLevelPlusThreshold; //Field offset: 0xC8
		public Single[] commonDifficultyPlusThreshold; //Field offset: 0xCC
		[Header("インゲームパラメータ")]
		public float ingameScoreTuneFactor; //Field offset: 0xD0
		public float freeModeScoreSpecifiedValue; //Field offset: 0xD4
		public int ingameTenSmallTakeCount; //Field offset: 0xD8
		public int ingameTenSmallScore; //Field offset: 0xDC
		public int ingameTenLargeTakeCount; //Field offset: 0xE0
		public int ingameTenLargeScore; //Field offset: 0xE4
		public int ingameComboMultiple; //Field offset: 0xE8
		public Int32[] ingameScoreToCreatePowerItem; //Field offset: 0xEC
		public float touchModeBeginFuzzyJudgeTime; //Field offset: 0xF0
		[Header("フリーモード設定")]
		public int BaseCost; //Field offset: 0xF4
		public float CostRate; //Field offset: 0xF8
		public int MaxCount; //Field offset: 0xFC
		public float MusicListSliderDelay; //Field offset: 0x100
		public int FreeModeMusicType; //Field offset: 0x104

		public Data() { }

	}

	[SerializeField]
	private Data entity; //Field offset: 0xC

	public DefaultDataScriptableObject() { }

	public override void FromJson(string json) { }

	public Data Get() { }

	public override string ToJson() { }

}

