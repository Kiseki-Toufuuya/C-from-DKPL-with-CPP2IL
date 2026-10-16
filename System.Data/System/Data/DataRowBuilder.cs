namespace System.Data;

public sealed class DataRowBuilder
{
	internal readonly DataTable _table; //Field offset: 0x8
	internal int _record; //Field offset: 0xC

	internal DataRowBuilder(DataTable table, int record) { }

}

