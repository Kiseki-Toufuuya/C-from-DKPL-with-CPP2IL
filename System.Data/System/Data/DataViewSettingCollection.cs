namespace System.Data;

[DefaultMember("Item")]
public class DataViewSettingCollection
{
	private readonly DataViewManager _dataViewManager; //Field offset: 0x8
	private readonly Hashtable _list; //Field offset: 0xC

	public override DataViewSetting Item
	{
		 get { } //Length: 288
		 set { } //Length: 150
	}

	public override DataViewSetting get_Item(DataTable table) { }

	internal void Remove(DataTable table) { }

	public override void set_Item(DataTable table, DataViewSetting value) { }

}

