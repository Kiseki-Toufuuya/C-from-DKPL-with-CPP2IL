namespace System.Data;

[DefaultMember("Item")]
public class DataRow
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataTable _table; //Field offset: 0x8
	private readonly DataColumnCollection _columns; //Field offset: 0xC
	internal int _oldRecord; //Field offset: 0x10
	internal int _newRecord; //Field offset: 0x14
	internal int _tempRecord; //Field offset: 0x18
	internal long _rowID; //Field offset: 0x20
	internal DataRowAction _action; //Field offset: 0x28
	internal bool _inChangingEvent; //Field offset: 0x2C
	internal bool _inDeletingEvent; //Field offset: 0x2D
	internal bool _inCascade; //Field offset: 0x2E
	private DataColumn _lastChangedColumn; //Field offset: 0x30
	private int _countColumnChange; //Field offset: 0x34
	private DataError _error; //Field offset: 0x38
	private int _rbTreeNodeId; //Field offset: 0x3C
	internal readonly int _objectID; //Field offset: 0x40

	public bool HasErrors
	{
		 get { } //Length: 50
	}

	internal bool HasPropertyChanged
	{
		internal get { } //Length: 15
	}

	public string Item
	{
		 set { } //Length: 105
	}

	public object Item
	{
		 get { } //Length: 229
		 set { } //Length: 1067
	}

	public object Item
	{
		 get { } //Length: 159
	}

	public Object[] ItemArray
	{
		 set { } //Length: 1090
	}

	internal DataColumn LastChangedColumn
	{
		internal get { } //Length: 21
		internal set { } //Length: 30
	}

	internal int RBTreeNodeId
	{
		internal get { } //Length: 11
		internal set { } //Length: 131
	}

	public string RowError
	{
		 get { } //Length: 32
		 set { } //Length: 385
	}

	internal long rowID
	{
		internal get { } //Length: 14
		internal set { } //Length: 50
	}

	public DataRowState RowState
	{
		 get { } //Length: 347
	}

	public DataTable Table
	{
		 get { } //Length: 11
	}

	protected private DataRow(DataRowBuilder builder) { }

	public void AcceptChanges() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void BeginEdit() { }

	private bool BeginEditInternal() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void CancelEdit() { }

	private void CheckColumn(DataColumn column) { }

	internal void CheckForLoops(DataRelation rel) { }

	internal void CheckInTable() { }

	internal void ClearError(DataColumn column) { }

	public void ClearErrors() { }

	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

	public void Delete() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void EndEdit() { }

	public bool get_HasErrors() { }

	internal bool get_HasPropertyChanged() { }

	public object get_Item(DataColumn column) { }

	public object get_Item(DataColumn column, DataRowVersion version) { }

	internal DataColumn get_LastChangedColumn() { }

	internal int get_RBTreeNodeId() { }

	public string get_RowError() { }

	internal long get_rowID() { }

	public DataRowState get_RowState() { }

	public DataTable get_Table() { }

	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	public DataRow[] GetChildRows(DataRelation relation) { }

	public string GetColumnError(DataColumn column) { }

	public DataColumn[] GetColumnsInError() { }

	internal Object[] GetColumnValues(DataColumn[] columns) { }

	internal Object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	internal int GetCurrentRecordNo() { }

	internal DataColumn GetDataColumn(string columnName) { }

	internal int GetDefaultRecord() { }

	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	internal Object[] GetKeyValues(DataKey key) { }

	internal Object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	internal int GetNestedParentCount() { }

	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	internal int GetOriginalRecordNo() { }

	public DataRow GetParentRow(DataRelation relation) { }

	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	public DataRow[] GetParentRows(DataRelation relation) { }

	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	private int GetProposedRecordNo() { }

	internal int GetRecordFromVersion(DataRowVersion version) { }

	internal DataViewRowState GetRecordState(int record) { }

	internal bool HasKeyChanged(DataKey key) { }

	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	public bool HasVersion(DataRowVersion version) { }

	internal bool HaveValuesChanged(DataColumn[] columns) { }

	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	public void RejectChanges() { }

	internal void ResetLastChangedColumn() { }

	private void RowErrorChanged() { }

	public void set_Item(string columnName, object value) { }

	public void set_Item(DataColumn column, object value) { }

	public void set_ItemArray(Object[] value) { }

	internal void set_LastChangedColumn(DataColumn value) { }

	internal void set_RBTreeNodeId(int value) { }

	public void set_RowError(string value) { }

	internal void set_rowID(long value) { }

	public void SetColumnError(DataColumn column, string error) { }

	public void SetColumnError(int columnIndex, string error) { }

	internal void SetKeyValues(DataKey key, Object[] keyValues) { }

	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	internal void SetParentRowToDBNull(DataRelation relation) { }

	internal void SetParentRowToDBNull() { }

}

