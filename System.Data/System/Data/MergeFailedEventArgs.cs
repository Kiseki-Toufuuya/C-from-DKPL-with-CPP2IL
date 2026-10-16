namespace System.Data;

public class MergeFailedEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; //Field offset: 0xC

	public string Conflict
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MergeFailedEventArgs(DataTable table, string conflict) { }

	[CompilerGenerated]
	public string get_Conflict() { }

}

