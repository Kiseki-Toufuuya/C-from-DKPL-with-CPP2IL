namespace System.Xml.Schema;

internal sealed class ConstraintStruct
{
	internal CompiledIdentityConstraint constraint; //Field offset: 0x8
	internal SelectorActiveAxis axisSelector; //Field offset: 0xC
	internal ArrayList axisFields; //Field offset: 0x10
	internal Hashtable qualifiedTable; //Field offset: 0x14
	internal Hashtable keyrefTable; //Field offset: 0x18
	private int tableDim; //Field offset: 0x1C

	internal int TableDim
	{
		internal get { } //Length: 11
	}

	internal ConstraintStruct(CompiledIdentityConstraint constraint) { }

	internal int get_TableDim() { }

}

