namespace System.Data;

[DefaultProperty("ConstraintName")]
[TypeConverter(typeof(ConstraintConverter))]
public abstract class Constraint
{
	private string _schemaName; //Field offset: 0x8
	private bool _inCollection; //Field offset: 0xC
	private DataSet _dataSet; //Field offset: 0x10
	internal string _name; //Field offset: 0x14
	internal PropertyCollection _extendedProperties; //Field offset: 0x18

	[CLSCompliant(False)]
	protected override DataSet _DataSet
	{
		 get { } //Length: 11
	}

	[DefaultValue(null)]
	public override string ConstraintName
	{
		 get { } //Length: 11
		 set { } //Length: 460
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 87
	}

	internal override bool InCollection
	{
		internal get { } //Length: 11
		internal set { } //Length: 89
	}

	internal string SchemaName
	{
		internal get { } //Length: 53
		internal set { } //Length: 44
	}

	public abstract DataTable Table
	{
		 get { } //Length: 0
	}

	protected Constraint() { }

	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	internal abstract bool CanEnableConstraint() { }

	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	internal void CheckConstraint() { }

	internal abstract void CheckState() { }

	protected void CheckStateForProperty() { }

	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	internal abstract Constraint Clone(DataSet destination) { }

	internal abstract bool ContainsColumn(DataColumn column) { }

	protected override DataSet get__DataSet() { }

	public override string get_ConstraintName() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal override bool get_InCollection() { }

	internal string get_SchemaName() { }

	public abstract DataTable get_Table() { }

	internal abstract bool IsConstraintViolated() { }

	public override void set_ConstraintName(string value) { }

	internal override void set_InCollection(bool value) { }

	internal void set_SchemaName(string value) { }

	public virtual string ToString() { }

}

