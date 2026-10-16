namespace XeApp.Game.Net;

public class ItemDatabase
{
	[CompilerGenerated]
	private static ItemDatabase <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsReady>k__BackingField; //Field offset: 0x8

	public private static ItemDatabase Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public bool IsReady
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ItemDatabase() { }

	public void AddItem(int prefixID, int itemValue, int count, string clubId = null) { }

	[CompilerGenerated]
	public static ItemDatabase get_Instance() { }

	[CompilerGenerated]
	public bool get_IsReady() { }

	public int GetActiveIds() { }

	public List<Int32> GetActiveIds(int itemPrefix) { }

	public string GetItemDescription(int prefixID, int itemValue) { }

	public int GetItemHaveCount(int prefixID, int itemValue, string clubId = null) { }

	public int GetItemHaveMaxCount(int prefixID, int itemValue) { }

	public int GetItemIconID(int prefix, int itemValue) { }

	public string GetItemName(int prefixID, int itemValue) { }

	[CompilerGenerated]
	private static void set_Instance(ItemDatabase value) { }

	[CompilerGenerated]
	public void set_IsReady(bool value) { }

	public void SetItemHaveCount(int prefixID, int itemValue, int count, string clubId = null) { }

}

