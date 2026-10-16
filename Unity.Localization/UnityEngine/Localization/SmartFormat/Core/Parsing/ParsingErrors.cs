namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public class ParsingErrors : Exception
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ParsingIssue, String> <>9__9_0; //Field offset: 0x4
		public static Func<ParsingIssue, String> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <get_Message>b__11_0(ParsingIssue i) { }

		internal string <get_MessageShort>b__9_0(ParsingIssue i) { }

	}

	internal class ParsingIssue
	{
		[CompilerGenerated]
		private readonly int <Index>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly int <Length>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private readonly string <Issue>k__BackingField; //Field offset: 0x10

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

		public int Length
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public ParsingIssue(string issue, int index, int length) { }

		[CompilerGenerated]
		public int get_Index() { }

		[CompilerGenerated]
		public string get_Issue() { }

		[CompilerGenerated]
		public int get_Length() { }

	}

	private Format result; //Field offset: 0x48
	[CompilerGenerated]
	private readonly List<ParsingIssue> <Issues>k__BackingField; //Field offset: 0x4C

	public bool HasIssues
	{
		 get { } //Length: 56
	}

	public List<ParsingIssue> Issues
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual string Message
	{
		 get { } //Length: 1328
	}

	public string MessageShort
	{
		 get { } //Length: 418
	}

	public ParsingErrors() { }

	public void AddIssue(string issue, int startIndex, int endIndex) { }

	public void Clear() { }

	public bool get_HasIssues() { }

	[CompilerGenerated]
	public List<ParsingIssue> get_Issues() { }

	public virtual string get_Message() { }

	public string get_MessageShort() { }

	public void Init(Format result) { }

}

