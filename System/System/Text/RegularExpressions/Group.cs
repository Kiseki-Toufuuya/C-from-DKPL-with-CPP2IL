namespace System.Text.RegularExpressions;

public class Group : Capture
{
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	internal readonly Int32[] _caps; //Field offset: 0x14
	internal int _capcount; //Field offset: 0x18
	internal CaptureCollection _capcoll; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x20

	public CaptureCollection Captures
	{
		 get { } //Length: 121
	}

	public bool Success
	{
		 get { } //Length: 15
	}

	private static Group() { }

	internal Group(string text, Int32[] caps, int capcount, string name) { }

	internal Group() { }

	public CaptureCollection get_Captures() { }

	public bool get_Success() { }

}

