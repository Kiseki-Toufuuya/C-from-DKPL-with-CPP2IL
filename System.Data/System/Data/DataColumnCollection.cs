namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase
{
	private readonly DataTable _table; //Field offset: 0x8
	private readonly ArrayList _list; //Field offset: 0xC
	private int _defaultNameIndex; //Field offset: 0x10
	private DataColumn[] _delayedAddRangeColumns; //Field offset: 0x14
	private readonly Dictionary<String, DataColumn> _columnFromName; //Field offset: 0x18
	private bool _fInClear; //Field offset: 0x1C
	private DataColumn[] _columnsImplementingIChangeTracking; //Field offset: 0x20
	private int _nColumnsImplementingIChangeTracking; //Field offset: 0x24
	private int _nColumnsImplementingIRevertibleChangeTracking; //Field offset: 0x28
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; //Field offset: 0x2C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; //Field offset: 0x30
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; //Field offset: 0x34

	public event CollectionChangeEventHandler CollectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	internal event CollectionChangeEventHandler ColumnPropertyChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 116
		[CompilerGenerated]
		internal remove { } //Length: 116
	}

	internal DataColumn[] ColumnsImplementingIChangeTracking
	{
		internal get { } //Length: 11
	}

	internal int ColumnsImplementingIChangeTrackingCount
	{
		internal get { } //Length: 11
	}

	internal int ColumnsImplementingIRevertibleChangeTrackingCount
	{
		internal get { } //Length: 11
	}

	public DataColumn Item
	{
		 get { } //Length: 310
	}

	public DataColumn Item
	{
		 get { } //Length: 297
	}

	internal DataColumn Item
	{
		internal get { } //Length: 127
	}

	protected virtual ArrayList List
	{
		 get { } //Length: 11
	}

	internal DataColumnCollection(DataTable table) { }

	public void Add(DataColumn column) { }

	[CompilerGenerated]
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	internal void AddAt(int index, DataColumn column) { }

	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	private void ArrayAdd(int index, DataColumn column) { }

	private void ArrayAdd(DataColumn column) { }

	private void ArrayRemove(DataColumn column) { }

	internal string AssignName() { }

	private void BaseAdd(DataColumn column) { }

	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	private void BaseRemove(DataColumn column) { }

	internal bool CanRegisterName(string name) { }

	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	private void CheckIChangeTracking(DataColumn column) { }

	public void Clear() { }

	public bool Contains(string name) { }

	internal bool Contains(string name, bool caseSensitive) { }

	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	public DataColumn get_Item(string name) { }

	public DataColumn get_Item(int index) { }

	internal DataColumn get_Item(string name, string ns) { }

	protected virtual ArrayList get_List() { }

	public int IndexOf(string columnName) { }

	internal int IndexOfCaseInsensitive(string name) { }

	private string MakeName(int index) { }

	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	internal void RegisterColumnName(string name, DataColumn column) { }

	public void Remove(DataColumn column) { }

	[CompilerGenerated]
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	internal void UnregisterName(string name) { }

}

