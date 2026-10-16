namespace Heqet;

public class PlayerData : ISaveDataContainer, ISerializationCallbackReceiver
{
	internal class AchievementData
	{
		public bool itemRewardAcquired; //Field offset: 0x8
		public bool isVisibled; //Field offset: 0x9

		public AchievementData() { }

	}

	internal class FormationData
	{
		public int mitama_card_id; //Field offset: 0x8
		public int heroine_main_id; //Field offset: 0xC
		public int heroine_sub_id; //Field offset: 0x10

		public FormationData() { }

		public void Init() { }

	}

	internal class InventoryData
	{
		internal class CardData
		{
			public int id; //Field offset: 0x8
			[SerializeField]
			private int lv; //Field offset: 0xC
			public int exp; //Field offset: 0x10
			public long acquisition_timestamp; //Field offset: 0x18

			public int Level
			{
				 get { } //Length: 11
				 set { } //Length: 612
			}

			public CardData() { }

			public static int CalceLevel(int id, int exp) { }

			public static int CalcNextExp(int id, int level) { }

			public int get_Level() { }

			public void set_Level(int value) { }

		}

		internal class HeroineData
		{
			public int id; //Field offset: 0x8
			public long acquisition_timestamp; //Field offset: 0x10

			public HeroineData() { }

		}

		[SerializeField]
		public SerializableDictionary<Int32, CardData> CardList; //Field offset: 0x8
		[SerializeField]
		public SerializableHashSet<Int32> EmblemHashSet; //Field offset: 0xC
		[SerializeField]
		public SerializableHashSet<Int32> RewardMoneyHashSet; //Field offset: 0x10
		[SerializeField]
		public SerializableDictionary<Int32, HeroineData> HeroineList; //Field offset: 0x14

		public InventoryData() { }

		public CardData AddCard(int id) { }

		public bool AddEmblem(int id) { }

		public HeroineData AddHeroine(int id) { }

		public bool AddRewardMoney(int id) { }

		public bool ContainsEmblem(int id) { }

		public bool ContainsRewardMoney(int id) { }

		public CardData GetCardData(int id) { }

		public HeroineData GetHeroineData(int id) { }

		public void Init() { }

	}

	internal class ShopItemData
	{
		public List<Int32> lineup; //Field offset: 0x8

		public ShopItemData() { }

		public void Init() { }

	}

	internal class SortFilterData
	{
		public int sort; //Field offset: 0x8
		public int order; //Field offset: 0xC
		public ulong filter; //Field offset: 0x10
		public string search; //Field offset: 0x18

		public SortFilterData() { }

	}

	internal class WorldMapData
	{
		internal class SpotData
		{
			public bool isOpen; //Field offset: 0x8
			public bool isRenaissance; //Field offset: 0x9
			public bool isArrival; //Field offset: 0xA
			public int lastSelectStageDataId; //Field offset: 0xC

			public SpotData() { }

		}

		internal class StageData
		{
			public bool isOpen; //Field offset: 0x8
			public bool isClear; //Field offset: 0x9
			public bool isFavorite; //Field offset: 0xA
			public int lastSelectDificulty; //Field offset: 0xC
			public int lastSelectLaneMode; //Field offset: 0x10
			public Boolean[] rewardReceived; //Field offset: 0x14
			public Boolean[] missionClear; //Field offset: 0x18

			public StageData() { }

			public bool IsAllMissionClear(int stageId) { }

		}

		[SerializeField]
		public List<Int32> OpenArea; //Field offset: 0x8
		[SerializeField]
		private SerializableDictionary<Int32, SpotData> spotData; //Field offset: 0xC
		[SerializeField]
		private SerializableDictionary<Int32, StageData> stageData; //Field offset: 0x10
		[CompilerGenerated]
		[SerializeField]
		private int <LastSelectSpot>k__BackingField; //Field offset: 0x14
		[SerializeField]
		public bool isStartStageSelect; //Field offset: 0x18

		public int LastSelectSpot
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public SerializableDictionary<Int32, StageData> StageDataDic
		{
			 get { } //Length: 11
		}

		public WorldMapData() { }

		public WorldMapData(WorldMapData dest) { }

		[CompilerGenerated]
		public int get_LastSelectSpot() { }

		public SerializableDictionary<Int32, StageData> get_StageDataDic() { }

		public int GetRenaissanceValue() { }

		public int GetRenaissanceValueBySpotId(int spotId) { }

		public SpotData GetSpotData(int id) { }

		public StageData GetStageData(int id) { }

		public void Init() { }

		public bool isEntrySpotData(int id) { }

		[CompilerGenerated]
		public void set_LastSelectSpot(int value) { }

	}

	public const int MAX_MONEY = 9999999; //Field offset: 0x0
	public const int MAX_REWORDS = 3; //Field offset: 0x0
	public const int MAX_MISSIONS = 2; //Field offset: 0x0
	public const int REWORD_STAGE_CLEAR = 0; //Field offset: 0x0
	public const int REWORD_MISSION_CLEAR = 1; //Field offset: 0x0
	public const int REWORD_DROP = 2; //Field offset: 0x0
	[SerializeField]
	private int money; //Field offset: 0x8
	[SerializeField]
	private uint total_money; //Field offset: 0xC
	[SerializeField]
	private uint total_kagura_stageclear_count; //Field offset: 0x10
	[SerializeField]
	private uint total_danmaku_stageclear_count; //Field offset: 0x14
	[SerializeField]
	private int total_boss_break_count; //Field offset: 0x18
	[SerializeField]
	private int total_normal_enemy_kill_count; //Field offset: 0x1C
	[SerializeField]
	private SerializableDictionary<Int32, SortFilterData> sortFilterData; //Field offset: 0x20
	[SerializeField]
	private WorldMapData m_WorldMap; //Field offset: 0x24
	[SerializeField]
	private InventoryData m_Inventory; //Field offset: 0x28
	[SerializeField]
	private FormationData m_Formation; //Field offset: 0x2C
	[SerializeField]
	private ShopItemData m_ShopItem; //Field offset: 0x30
	[SerializeField]
	private SerializableHashSet<Int32> m_SeenHelpGroupHashSet; //Field offset: 0x34
	[SerializeField]
	private SerializableDictionary<Int32, AchievementData> m_achievementHashSet; //Field offset: 0x38

	public SerializableDictionary<Int32, AchievementData> Achievement
	{
		 get { } //Length: 11
	}

	public FormationData Formation
	{
		 get { } //Length: 11
	}

	public override short FormatVersion
	{
		 get { } //Length: 6
	}

	public InventoryData Inventory
	{
		 get { } //Length: 11
	}

	public int Money
	{
		 get { } //Length: 11
		 set { } //Length: 64
	}

	public SerializableHashSet<Int32> SeenHelpGroup
	{
		 get { } //Length: 11
	}

	public ShopItemData ShopItem
	{
		 get { } //Length: 11
	}

	public override uint Signature
	{
		 get { } //Length: 6
	}

	public int TotalBossBreakCount
	{
		 get { } //Length: 11
		 set { } //Length: 21
	}

	public uint TotalDanmakuStageClearCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uint TotalKaguraStageClearCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uint TotalMoney
	{
		 get { } //Length: 11
	}

	public int TotalNormalEnemyKillCount
	{
		 get { } //Length: 11
		 set { } //Length: 21
	}

	public WorldMapData WorldMap
	{
		 get { } //Length: 11
	}

	public PlayerData() { }

	public void AddHeroine(int heroienId) { }

	public override void CopyTo(object dest) { }

	public override bool DeserializeFromBytes(int version, Byte[] bytes) { }

	public SerializableDictionary<Int32, AchievementData> get_Achievement() { }

	public FormationData get_Formation() { }

	public override short get_FormatVersion() { }

	public InventoryData get_Inventory() { }

	public int get_Money() { }

	public SerializableHashSet<Int32> get_SeenHelpGroup() { }

	public ShopItemData get_ShopItem() { }

	public override uint get_Signature() { }

	public int get_TotalBossBreakCount() { }

	public uint get_TotalDanmakuStageClearCount() { }

	public uint get_TotalKaguraStageClearCount() { }

	public uint get_TotalMoney() { }

	public int get_TotalNormalEnemyKillCount() { }

	public WorldMapData get_WorldMap() { }

	public SortFilterData GetSortFilterData(int id) { }

	public override bool Match(object dest) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override void ResetToDefault() { }

	public override Byte[] SerializeToBytes() { }

	public void set_Money(int value) { }

	public void set_TotalBossBreakCount(int value) { }

	public void set_TotalDanmakuStageClearCount(uint value) { }

	public void set_TotalKaguraStageClearCount(uint value) { }

	public void set_TotalNormalEnemyKillCount(int value) { }

	private void VersionValidate(int version) { }

	private void VersionValidate_Ver1To2() { }

}

