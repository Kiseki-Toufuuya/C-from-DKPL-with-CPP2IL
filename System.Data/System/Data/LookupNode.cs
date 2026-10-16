namespace System.Data;

internal sealed class LookupNode : ExpressionNode
{
	private readonly string _relationName; //Field offset: 0xC
	private readonly string _columnName; //Field offset: 0x10
	private DataColumn _column; //Field offset: 0x14
	private DataRelation _relation; //Field offset: 0x18

	internal LookupNode(DataTable table, string columnName, string relationName) { }

	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	internal virtual bool DependsOn(DataColumn column) { }

	internal virtual object Eval() { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	internal virtual object Eval(Int32[] recordNos) { }

	internal virtual bool HasLocalAggregate() { }

	internal virtual bool HasRemoteAggregate() { }

	internal virtual bool IsConstant() { }

	internal virtual bool IsTableConstant() { }

	internal virtual ExpressionNode Optimize() { }

}

