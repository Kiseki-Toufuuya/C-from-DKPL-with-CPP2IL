namespace System.Data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting
{
	private DataViewManager _dataViewManager; //Field offset: 0x8
	private DataTable _table; //Field offset: 0xC
	private string _sort; //Field offset: 0x10
	private string _rowFilter; //Field offset: 0x14
	private DataViewRowState _rowStateFilter; //Field offset: 0x18
	private bool _applyDefaultSort; //Field offset: 0x1C

	public bool ApplyDefaultSort
	{
		 get { } //Length: 11
	}

	public string RowFilter
	{
		 get { } //Length: 11
	}

	public DataViewRowState RowStateFilter
	{
		 get { } //Length: 11
	}

	public string Sort
	{
		 get { } //Length: 11
	}

	internal DataViewSetting() { }

	public bool get_ApplyDefaultSort() { }

	public string get_RowFilter() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

	internal void SetDataTable(DataTable table) { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

}

