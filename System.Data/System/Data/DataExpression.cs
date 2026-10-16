namespace System.Data;

internal sealed class DataExpression : IFilter
{
	internal string _originalExpression; //Field offset: 0x8
	private bool _parsed; //Field offset: 0xC
	private bool _bound; //Field offset: 0xD
	private ExpressionNode _expr; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x14
	private readonly StorageType _storageType; //Field offset: 0x18
	private readonly Type _dataType; //Field offset: 0x1C
	private DataColumn[] _dependency; //Field offset: 0x20

	internal string Expression
	{
		internal get { } //Length: 53
	}

	internal bool HasValue
	{
		internal get { } //Length: 15
	}

	internal DataExpression(DataTable table, string expression) { }

	internal DataExpression(DataTable table, string expression, Type type) { }

	internal void Bind(DataTable table) { }

	internal bool DependsOn(DataColumn column) { }

	internal object Evaluate() { }

	internal object Evaluate(DataRow row, DataRowVersion version) { }

	internal string get_Expression() { }

	internal bool get_HasValue() { }

	internal DataColumn[] GetDependency() { }

	internal bool HasLocalAggregate() { }

	internal bool HasRemoteAggregate() { }

	public override bool Invoke(DataRow row, DataRowVersion version) { }

	internal bool IsTableAggregate() { }

	internal static bool IsUnknown(object value) { }

	internal static bool ToBoolean(object value) { }

}

