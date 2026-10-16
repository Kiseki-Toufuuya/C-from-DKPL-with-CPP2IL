namespace System.Data;

internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	private readonly DataTable _table; //Field offset: 0x14

	public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) { }

	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

