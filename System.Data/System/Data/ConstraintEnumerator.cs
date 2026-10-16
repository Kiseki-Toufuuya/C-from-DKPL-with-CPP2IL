namespace System.Data;

internal class ConstraintEnumerator
{
	private IEnumerator _tables; //Field offset: 0x8
	private IEnumerator _constraints; //Field offset: 0xC
	private Constraint _currentObject; //Field offset: 0x10

	protected Constraint CurrentObject
	{
		 get { } //Length: 11
	}

	public ConstraintEnumerator(DataSet dataSet) { }

	protected Constraint get_CurrentObject() { }

	public Constraint GetConstraint() { }

	public bool GetNext() { }

	protected override bool IsValidCandidate(Constraint constraint) { }

}

