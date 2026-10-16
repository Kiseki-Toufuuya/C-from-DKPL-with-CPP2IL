namespace UnityEngine.Localization.SmartFormat;

public class FormattingErrorEventArgs : EventArgs
{
	[CompilerGenerated]
	private string <Placeholder>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <ErrorIndex>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private bool <IgnoreError>k__BackingField; //Field offset: 0x10

	public internal int ErrorIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public internal bool IgnoreError
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public internal string Placeholder
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	internal FormattingErrorEventArgs(string rawText, int errorIndex, bool ignoreError) { }

	[CompilerGenerated]
	public int get_ErrorIndex() { }

	[CompilerGenerated]
	public bool get_IgnoreError() { }

	[CompilerGenerated]
	public string get_Placeholder() { }

	[CompilerGenerated]
	internal void set_ErrorIndex(int value) { }

	[CompilerGenerated]
	internal void set_IgnoreError(bool value) { }

	[CompilerGenerated]
	internal void set_Placeholder(string value) { }

}

