namespace System.Data;

[DefaultEvent("PositionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable
{
	private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
	{
		internal static readonly DataRowReferenceComparer s_default; //Field offset: 0x0

		private static DataRowReferenceComparer() { }

		private DataRowReferenceComparer() { }

		public override bool Equals(DataRow x, DataRow y) { }

		public override int GetHashCode(DataRow obj) { }

	}

	internal static ListChangedEventArgs s_resetEventArgs; //Field offset: 0x0
	private static int s_objectTypeCount; //Field offset: 0x4
	private DataViewManager _dataViewManager; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x14
	private bool _locked; //Field offset: 0x18
	private Index _index; //Field offset: 0x1C
	private Dictionary<String, Index> _findIndexes; //Field offset: 0x20
	private string _sort; //Field offset: 0x24
	private Comparison<DataRow> _comparison; //Field offset: 0x28
	private IFilter _rowFilter; //Field offset: 0x2C
	private DataViewRowState _recordStates; //Field offset: 0x30
	private bool _shouldOpen; //Field offset: 0x34
	private bool _open; //Field offset: 0x35
	private bool _allowNew; //Field offset: 0x36
	private bool _allowEdit; //Field offset: 0x37
	private bool _allowDelete; //Field offset: 0x38
	private bool _applyDefaultSort; //Field offset: 0x39
	internal DataRow _addNewRow; //Field offset: 0x3C
	private ListChangedEventArgs _addNewMoved; //Field offset: 0x40
	private ListChangedEventHandler _onListChanged; //Field offset: 0x44
	private DataViewRowState _delayedRecordStates; //Field offset: 0x48
	private bool _fEndInitInProgress; //Field offset: 0x4C
	private Dictionary<DataRow, DataRowView> _rowViewCache; //Field offset: 0x50
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; //Field offset: 0x54
	private DataViewListener _dvListener; //Field offset: 0x58
	private readonly int _objectID; //Field offset: 0x5C

	[DefaultValue(True)]
	public bool AllowDelete
	{
		 get { } //Length: 11
	}

	[DefaultValue(True)]
	public bool AllowNew
	{
		 get { } //Length: 11
	}

	[Browsable(False)]
	public override int Count
	{
		 get { } //Length: 64
	}

	private int CountFromIndex
	{
		private get { } //Length: 44
	}

	[Browsable(False)]
	public DataViewManager DataViewManager
	{
		 get { } //Length: 11
	}

	[Browsable(False)]
	protected bool IsOpen
	{
		 get { } //Length: 11
	}

	public DataRowView Item
	{
		 get { } //Length: 85
	}

	internal int ObjectID
	{
		internal get { } //Length: 11
	}

	[DefaultValue(DataViewRowState::CurrentRows (22))]
	public DataViewRowState RowStateFilter
	{
		 get { } //Length: 11
	}

	[DefaultValue(null)]
	public string Sort
	{
		 get { } //Length: 82
	}

	internal Comparison<DataRow> SortComparison
	{
		internal get { } //Length: 11
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 8
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 85
		private set { } //Length: 30
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table
	{
		 get { } //Length: 11
	}

	private static DataView() { }

	internal DataView(DataTable table, bool locked) { }

	public override DataRowView AddNew() { }

	private void CheckOpen() { }

	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	protected void Close() { }

	protected override void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	private void CopyTo(DataRowView[] array, int index) { }

	public override void CopyTo(Array array, int index) { }

	internal void Delete(DataRow row) { }

	public void Delete(int index) { }

	protected virtual void Dispose(bool disposing) { }

	internal void FinishAddNew(bool success) { }

	public bool get_AllowDelete() { }

	public bool get_AllowNew() { }

	public override int get_Count() { }

	private int get_CountFromIndex() { }

	public DataViewManager get_DataViewManager() { }

	protected bool get_IsOpen() { }

	public DataRowView get_Item(int recordIndex) { }

	internal int get_ObjectID() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

	internal Comparison<DataRow> get_SortComparison() { }

	public DataTable get_Table() { }

	public override IEnumerator GetEnumerator() { }

	internal override IFilter GetFilter() { }

	private int GetRecord(int recordIndex) { }

	internal DataRow GetRow(int index) { }

	private DataRowView GetRowView(DataRow dr) { }

	private DataRowView GetRowView(int record) { }

	protected override void IndexListChanged(object sender, ListChangedEventArgs e) { }

	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	internal int IndexOf(DataRowView rowview) { }

	private int IndexOfDataRowView(DataRowView rowview) { }

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	protected override void OnListChanged(ListChangedEventArgs e) { }

	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	protected void Reset() { }

	internal void ResetRowViewCache() { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int recordIndex) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int recordIndex, object value) { }

	protected void UpdateIndex() { }

	protected override void UpdateIndex(bool force) { }

	internal void UpdateIndex(bool force, bool fireEvent) { }

}

