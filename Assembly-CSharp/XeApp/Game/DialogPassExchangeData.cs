namespace XeApp.Game;

public class DialogPassExchangeData
{
	internal class PassExchangeItemData
	{
		[CompilerGenerated]
		private int <ItemPrefix>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private int <ItemValue>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private int <ItemCount>k__BackingField; //Field offset: 0x10

		public int ItemCount
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public int ItemPrefix
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

		public PassExchangeItemData() { }

		[CompilerGenerated]
		public int get_ItemCount() { }

		[CompilerGenerated]
		public int get_ItemPrefix() { }

		[CompilerGenerated]
		public int get_ItemValue() { }

		[CompilerGenerated]
		public void set_ItemCount(int value) { }

		[CompilerGenerated]
		public void set_ItemPrefix(int value) { }

		[CompilerGenerated]
		public void set_ItemValue(int value) { }

	}

	private List<PassExchangeItemData> m_DataList; //Field offset: 0x8

	public DialogPassExchangeData() { }

	public void AddItem(int itemPrefix, int itemValue, int itemCount = 0) { }

	public int GetItemCount() { }

	public List<PassExchangeItemData> GetItemList() { }

}

