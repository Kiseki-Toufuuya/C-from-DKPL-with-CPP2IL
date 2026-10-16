namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public class ParsingErrorEventArgs : EventArgs
{
	[CompilerGenerated]
	private ParsingErrors <Errors>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; //Field offset: 0xC

	public internal ParsingErrors Errors
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public internal bool ThrowsException
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal ParsingErrorEventArgs(ParsingErrors errors, bool throwsException) { }

	[CompilerGenerated]
	public ParsingErrors get_Errors() { }

	[CompilerGenerated]
	public bool get_ThrowsException() { }

	[CompilerGenerated]
	internal void set_Errors(ParsingErrors value) { }

	[CompilerGenerated]
	internal void set_ThrowsException(bool value) { }

}

