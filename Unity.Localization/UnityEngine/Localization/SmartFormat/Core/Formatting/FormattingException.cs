namespace UnityEngine.Localization.SmartFormat.Core.Formatting;

public class FormattingException : Exception
{
	[CompilerGenerated]
	private readonly string <Format>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly FormatItem <ErrorItem>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly string <Issue>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x54

	public FormatItem ErrorItem
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Format
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Issue
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual string Message
	{
		 get { } //Length: 427
	}

	public FormattingException(FormatItem errorItem, Exception formatException, int index) { }

	public FormattingException(FormatItem errorItem, string issue, int index) { }

	[CompilerGenerated]
	public FormatItem get_ErrorItem() { }

	[CompilerGenerated]
	public string get_Format() { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public string get_Issue() { }

	public virtual string get_Message() { }

}

