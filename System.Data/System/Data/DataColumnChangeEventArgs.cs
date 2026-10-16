namespace System.Data;

public class DataColumnChangeEventArgs : EventArgs
{
	private DataColumn _column; //Field offset: 0x8
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; //Field offset: 0x10

	public object ProposedValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	internal DataColumnChangeEventArgs(DataRow row) { }

	public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	public object get_ProposedValue() { }

	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

	[CompilerGenerated]
	public void set_ProposedValue(object value) { }

}

