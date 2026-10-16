namespace System.Data;

[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private DataSet _dataSet; //Field offset: 0x8
	internal PropertyCollection _extendedProperties; //Field offset: 0xC
	internal string _relationName; //Field offset: 0x10
	private DataKey _childKey; //Field offset: 0x14
	private DataKey _parentKey; //Field offset: 0x18
	private UniqueConstraint _parentKeyConstraint; //Field offset: 0x1C
	private ForeignKeyConstraint _childKeyConstraint; //Field offset: 0x20
	internal String[] _parentColumnNames; //Field offset: 0x24
	internal String[] _childColumnNames; //Field offset: 0x28
	internal string _parentTableName; //Field offset: 0x2C
	internal string _childTableName; //Field offset: 0x30
	internal string _parentTableNamespace; //Field offset: 0x34
	internal string _childTableNamespace; //Field offset: 0x38
	internal bool _nested; //Field offset: 0x3C
	internal bool _createConstraints; //Field offset: 0x3D
	private bool _checkMultipleNested; //Field offset: 0x3E
	private readonly int _objectID; //Field offset: 0x40
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x44

	internal bool CheckMultipleNested
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal String[] ChildColumnNames
	{
		internal get { } //Length: 20
	}

	public override DataColumn[] ChildColumns
	{
		 get { } //Length: 32
	}

	internal DataColumn[] ChildColumnsReference
	{
		internal get { } //Length: 24
	}

	internal DataKey ChildKey
	{
		internal get { } //Length: 24
	}

	public override ForeignKeyConstraint ChildKeyConstraint
	{
		 get { } //Length: 24
	}

	public override DataTable ChildTable
	{
		 get { } //Length: 54
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public override DataSet DataSet
	{
		 get { } //Length: 24
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 87
	}

	[DefaultValue(False)]
	public override bool Nested
	{
		 get { } //Length: 24
		 set { } //Length: 3080
	}

	internal int ObjectID
	{
		internal get { } //Length: 11
	}

	internal String[] ParentColumnNames
	{
		internal get { } //Length: 20
	}

	public override DataColumn[] ParentColumns
	{
		 get { } //Length: 32
	}

	internal DataColumn[] ParentColumnsReference
	{
		internal get { } //Length: 11
	}

	internal DataKey ParentKey
	{
		internal get { } //Length: 24
	}

	public override UniqueConstraint ParentKeyConstraint
	{
		 get { } //Length: 24
	}

	public override DataTable ParentTable
	{
		 get { } //Length: 54
	}

	[DefaultValue(null)]
	public override string RelationName
	{
		 get { } //Length: 24
	}

	public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	public DataRelation(string relationName, string parentTableName, string childTableName, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	[Browsable(False)]
	public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	internal void CheckNestedRelations() { }

	internal void CheckState() { }

	protected void CheckStateForProperty() { }

	internal DataRelation Clone(DataSet destination) { }

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	internal bool get_CheckMultipleNested() { }

	internal String[] get_ChildColumnNames() { }

	public override DataColumn[] get_ChildColumns() { }

	internal DataColumn[] get_ChildColumnsReference() { }

	internal DataKey get_ChildKey() { }

	public override ForeignKeyConstraint get_ChildKeyConstraint() { }

	public override DataTable get_ChildTable() { }

	public override DataSet get_DataSet() { }

	public PropertyCollection get_ExtendedProperties() { }

	public override bool get_Nested() { }

	internal int get_ObjectID() { }

	internal String[] get_ParentColumnNames() { }

	public override DataColumn[] get_ParentColumns() { }

	internal DataColumn[] get_ParentColumnsReference() { }

	internal DataKey get_ParentKey() { }

	public override UniqueConstraint get_ParentKeyConstraint() { }

	public override DataTable get_ParentTable() { }

	public override string get_RelationName() { }

	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	private bool IsAutoGenerated(DataColumn col) { }

	private static bool IsKeyNull(Object[] values) { }

	protected private void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	protected private void RaisePropertyChanging(string name) { }

	internal void set_CheckMultipleNested(bool value) { }

	public override void set_Nested(bool value) { }

	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	internal void SetDataSet(DataSet dataSet) { }

	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	public virtual string ToString() { }

	internal void ValidateMultipleNestedRelations() { }

}

