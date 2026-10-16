namespace System.Data;

internal sealed class ConstraintTable
{
	public DataTable table; //Field offset: 0x8
	public XmlSchemaIdentityConstraint constraint; //Field offset: 0xC

	public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c) { }

}

