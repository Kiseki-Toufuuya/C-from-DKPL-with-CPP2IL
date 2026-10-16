namespace XeApp.Game.Net;

public class ItemReceiver
{
	internal enum BonusID
	{
		ExpeditionSuccess1 = 0,
		ExpeditionSuccess2 = 1,
		ExpeditionSuccess3 = 2,
		ScoreRunkBonusD = 4,
		ScoreRunkBonusC = 5,
		ScoreRunkBonusB = 6,
		ScoreRunkBonusA = 7,
		ScoreRunkBonusS = 8,
		ScoreRunkBonusSS = 9,
		BossDamageBonus1 = 10,
		BossDamageBonus2 = 11,
		BossDamageBonus3 = 12,
		BossDamageBonus4 = 13,
		BoxGachaPickup = 14,
		AdMobPickup = 14,
		ItemTypeBase = 15,
		ItemTypeScore = 15,
		ItemTypeBoss = 16,
		ItemTypeMax = 16,
	}

	internal enum ListType
	{
		AddUp = 0,
		Separete = 1,
	}

	internal enum Option
	{
		None = 0,
		ToInventory = 1,
		Trash = 2,
	}

	internal class ReceivedItem
	{
		[CompilerGenerated]
		private int <ItemValue>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private int <Count>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private bool <BoostDisable>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <Prefix>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private int <BonusBits>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Option <Option>k__BackingField; //Field offset: 0x1C

		public int BonusBits
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool BoostDisable
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public int Count
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public int ItemValue
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public Option Option
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public int Prefix
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public ReceivedItem() { }

		public ReceivedItem Clone() { }

		[CompilerGenerated]
		public int get_BonusBits() { }

		[CompilerGenerated]
		public bool get_BoostDisable() { }

		[CompilerGenerated]
		public int get_Count() { }

		[CompilerGenerated]
		public int get_ItemValue() { }

		[CompilerGenerated]
		public Option get_Option() { }

		[CompilerGenerated]
		public int get_Prefix() { }

		public bool IsBonus(BonusID id) { }

		[CompilerGenerated]
		public void set_BonusBits(int value) { }

		[CompilerGenerated]
		public void set_BoostDisable(bool value) { }

		[CompilerGenerated]
		public void set_Count(int value) { }

		[CompilerGenerated]
		public void set_ItemValue(int value) { }

		[CompilerGenerated]
		public void set_Option(Option value) { }

		[CompilerGenerated]
		public void set_Prefix(int value) { }

		public void UnlockCard(int id) { }

	}

	public List<ReceivedItem> ReceivedItems; //Field offset: 0x8
	public ListType ShowListType; //Field offset: 0xC

	public ItemReceiver() { }

	public bool CheckFully(ItemDatabase itemDatabase, int prefix, int itemValue, int addCount) { }

	public void Clear() { }

	public void ReceiveItem(ItemDatabase itemDatabase, int prefix, int itemValue, int addCount, Option option, int bonusBits = 0, bool boostDisable = false) { }

	public void SetRootId(LogRouteID id) { }

	public void SetRootOptions(long v0) { }

	public void SetRootOptions(long v0, long v1) { }

	public void SetRootOptions(long v0, long v1, long v2) { }

	public static bool UnlockCard(int itemValue, bool isPremium = false) { }

}

