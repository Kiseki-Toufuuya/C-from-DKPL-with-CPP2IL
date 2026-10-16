namespace System.Data;

[DefaultMember("Item")]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
[ToolboxItem(False)]
public class DataColumn : MarshalByValueComponent
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private bool _allowNull; //Field offset: 0x10
	private string _caption; //Field offset: 0x14
	private string _columnName; //Field offset: 0x18
	private Type _dataType; //Field offset: 0x1C
	private StorageType _storageType; //Field offset: 0x20
	internal object _defaultValue; //Field offset: 0x24
	private DataSetDateTime _dateTimeMode; //Field offset: 0x28
	private DataExpression _expression; //Field offset: 0x2C
	private int _maxLength; //Field offset: 0x30
	private int _ordinal; //Field offset: 0x34
	private bool _readOnly; //Field offset: 0x38
	internal Index _sortIndex; //Field offset: 0x3C
	internal DataTable _table; //Field offset: 0x40
	private bool _unique; //Field offset: 0x44
	internal MappingType _columnMapping; //Field offset: 0x48
	internal int _hashCode; //Field offset: 0x4C
	internal int _errors; //Field offset: 0x50
	private bool _isSqlType; //Field offset: 0x54
	private bool _implementsINullable; //Field offset: 0x55
	private bool _implementsIChangeTracking; //Field offset: 0x56
	private bool _implementsIRevertibleChangeTracking; //Field offset: 0x57
	private bool _implementsIXMLSerializable; //Field offset: 0x58
	private bool _defaultValueIsNull; //Field offset: 0x59
	internal List<DataColumn> _dependentColumns; //Field offset: 0x5C
	internal PropertyCollection _extendedProperties; //Field offset: 0x60
	private DataStorage _storage; //Field offset: 0x64
	private AutoIncrementValue _autoInc; //Field offset: 0x68
	internal string _columnUri; //Field offset: 0x6C
	private string _columnPrefix; //Field offset: 0x70
	internal string _encodedColumnName; //Field offset: 0x74
	internal SimpleType _simpleType; //Field offset: 0x78
	private readonly int _objectID; //Field offset: 0x7C
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x84

	[DefaultValue(True)]
	public bool AllowDBNull
	{
		 get { } //Length: 11
		 set { } //Length: 355
	}

	internal AutoIncrementValue AutoInc
	{
		internal get { } //Length: 206
	}

	[DefaultValue(False)]
	[RefreshProperties(RefreshProperties::All (1))]
	public bool AutoIncrement
	{
		 get { } //Length: 24
		 set { } //Length: 352
	}

	internal object AutoIncrementCurrent
	{
		internal get { } //Length: 82
		internal set { } //Length: 300
	}

	[DefaultValue(0)]
	public long AutoIncrementSeed
	{
		 get { } //Length: 43
		 set { } //Length: 230
	}

	[DefaultValue(1)]
	public long AutoIncrementStep
	{
		 get { } //Length: 46
		 set { } //Length: 219
	}

	public string Caption
	{
		 get { } //Length: 22
		 set { } //Length: 148
	}

	[DefaultValue(MappingType::Element (1))]
	public override MappingType ColumnMapping
	{
		 get { } //Length: 11
		 set { } //Length: 587
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string ColumnName
	{
		 get { } //Length: 11
		 set { } //Length: 789
	}

	internal bool Computed
	{
		internal get { } //Length: 15
	}

	internal DataExpression DataExpression
	{
		internal get { } //Length: 11
	}

	[DefaultValue(typeof(string))]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType
	{
		 get { } //Length: 11
		 set { } //Length: 2300
	}

	[DefaultValue(DataSetDateTime::UnspecifiedLocal (3))]
	[RefreshProperties(RefreshProperties::All (1))]
	public DataSetDateTime DateTimeMode
	{
		 get { } //Length: 11
		 set { } //Length: 268
	}

	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue
	{
		 get { } //Length: 285
		 set { } //Length: 769
	}

	internal bool DefaultValueIsNull
	{
		internal get { } //Length: 11
	}

	internal string EncodedColumnName
	{
		internal get { } //Length: 97
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string Expression
	{
		 get { } //Length: 63
		 set { } //Length: 1747
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 87
	}

	internal IFormatProvider FormatProvider
	{
		internal get { } //Length: 88
	}

	internal bool HasData
	{
		internal get { } //Length: 15
	}

	internal bool ImplementsIChangeTracking
	{
		internal get { } //Length: 11
	}

	internal bool ImplementsINullable
	{
		internal get { } //Length: 11
	}

	internal bool ImplementsIRevertibleChangeTracking
	{
		internal get { } //Length: 11
	}

	internal bool ImplementsIXMLSerializable
	{
		internal get { } //Length: 11
	}

	internal bool IsCustomType
	{
		internal get { } //Length: 87
	}

	internal bool IsSqlType
	{
		internal get { } //Length: 11
	}

	internal bool IsValueType
	{
		internal get { } //Length: 23
	}

	internal object Item
	{
		internal get { } //Length: 43
		internal set { } //Length: 430
	}

	internal CultureInfo Locale
	{
		internal get { } //Length: 81
	}

	[DefaultValue(-1)]
	public int MaxLength
	{
		 get { } //Length: 11
		 set { } //Length: 872
	}

	public string Namespace
	{
		 get { } //Length: 56
		 set { } //Length: 291
	}

	internal int ObjectID
	{
		internal get { } //Length: 11
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public int Ordinal
	{
		 get { } //Length: 11
	}

	[DefaultValue(null)]
	public string Prefix
	{
		 get { } //Length: 11
		 set { } //Length: 290
	}

	[DefaultValue(False)]
	public bool ReadOnly
	{
		 get { } //Length: 11
		 set { } //Length: 175
	}

	internal SimpleType SimpleType
	{
		internal get { } //Length: 11
		internal set { } //Length: 68
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Index SortIndex
	{
		private get { } //Length: 199
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataTable Table
	{
		 get { } //Length: 11
	}

	[DefaultValue(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public bool Unique
	{
		 get { } //Length: 11
		 set { } //Length: 882
	}

	internal string XmlDataType
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 33
	}

	public DataColumn() { }

	public DataColumn(string columnName, Type dataType) { }

	public DataColumn(string columnName, Type dataType, string expr, MappingType type) { }

	internal void AddDependentColumn(DataColumn expressionColumn) { }

	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	internal bool CheckMaxLength() { }

	internal void CheckMaxLength(DataRow dr) { }

	protected private void CheckNotAllowNull() { }

	internal void CheckNullable(DataRow row) { }

	protected void CheckUnique() { }

	internal DataColumn Clone() { }

	internal int Compare(int record1, int record2) { }

	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	internal int CompareValueTo(int record1, object value) { }

	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	internal string ConvertObjectToXml(object value) { }

	internal object ConvertValue(object value) { }

	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	internal object ConvertXmlToObject(string s) { }

	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	internal void FreeRecord(int record) { }

	public bool get_AllowDBNull() { }

	internal AutoIncrementValue get_AutoInc() { }

	public bool get_AutoIncrement() { }

	internal object get_AutoIncrementCurrent() { }

	public long get_AutoIncrementSeed() { }

	public long get_AutoIncrementStep() { }

	public string get_Caption() { }

	public override MappingType get_ColumnMapping() { }

	public string get_ColumnName() { }

	internal bool get_Computed() { }

	internal DataExpression get_DataExpression() { }

	public Type get_DataType() { }

	public DataSetDateTime get_DateTimeMode() { }

	public object get_DefaultValue() { }

	internal bool get_DefaultValueIsNull() { }

	internal string get_EncodedColumnName() { }

	public string get_Expression() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal IFormatProvider get_FormatProvider() { }

	internal bool get_HasData() { }

	internal bool get_ImplementsIChangeTracking() { }

	internal bool get_ImplementsINullable() { }

	internal bool get_ImplementsIRevertibleChangeTracking() { }

	internal bool get_ImplementsIXMLSerializable() { }

	internal bool get_IsCustomType() { }

	internal bool get_IsSqlType() { }

	internal bool get_IsValueType() { }

	internal object get_Item(int record) { }

	internal CultureInfo get_Locale() { }

	public int get_MaxLength() { }

	public string get_Namespace() { }

	internal int get_ObjectID() { }

	public int get_Ordinal() { }

	public string get_Prefix() { }

	public bool get_ReadOnly() { }

	internal SimpleType get_SimpleType() { }

	private Index get_SortIndex() { }

	public DataTable get_Table() { }

	public bool get_Unique() { }

	[CompilerGenerated]
	internal string get_XmlDataType() { }

	internal object GetAggregateValue(Int32[] records, AggregateType kind) { }

	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	private DataRow GetDataRow(int index) { }

	internal object GetEmptyColumnStore(int recordCount) { }

	private int GetStringLength(int record) { }

	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

	internal void Init(int record) { }

	internal void InitializeRecord(int record) { }

	private void InsureStorage() { }

	internal void InternalUnique(bool value) { }

	internal static bool IsAutoIncrementType(Type dataType) { }

	internal bool IsInRelation() { }

	internal bool IsMaxLengthViolated() { }

	internal bool IsNotAllowDBNullViolated() { }

	internal bool IsValueCustomTypeInstance(object value) { }

	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	internal void OnSetDataSet() { }

	protected private void RaisePropertyChanging(string name) { }

	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	public void set_AllowDBNull(bool value) { }

	public void set_AutoIncrement(bool value) { }

	internal void set_AutoIncrementCurrent(object value) { }

	public void set_AutoIncrementSeed(long value) { }

	public void set_AutoIncrementStep(long value) { }

	public void set_Caption(string value) { }

	public override void set_ColumnMapping(MappingType value) { }

	public void set_ColumnName(string value) { }

	public void set_DataType(Type value) { }

	public void set_DateTimeMode(DataSetDateTime value) { }

	public void set_DefaultValue(object value) { }

	public void set_Expression(string value) { }

	internal void set_Item(int record, object value) { }

	public void set_MaxLength(int value) { }

	public void set_Namespace(string value) { }

	public void set_Prefix(string value) { }

	public void set_ReadOnly(bool value) { }

	internal void set_SimpleType(SimpleType value) { }

	public void set_Unique(bool value) { }

	[CompilerGenerated]
	internal void set_XmlDataType(string value) { }

	internal void SetCapacity(int capacity) { }

	private void SetMaxLengthSimpleType() { }

	internal void SetOrdinalInternal(int ordinal) { }

	internal void SetStorage(object store, BitArray nullbits) { }

	internal void SetTable(DataTable table) { }

	internal void SetValue(int record, object value) { }

	public virtual string ToString() { }

	private void UpdateColumnType(Type type, StorageType typeCode) { }

}

