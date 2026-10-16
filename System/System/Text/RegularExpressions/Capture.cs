namespace System.Text.RegularExpressions;

public class Capture
{
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <Text>k__BackingField; //Field offset: 0x10

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	internal string Text
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string Value
	{
		 get { } //Length: 37
	}

	internal Capture(string text, int index, int length) { }

	internal Capture() { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	internal string get_Text() { }

	public string get_Value() { }

	internal ReadOnlySpan<Char> GetLeftSubstring() { }

	internal ReadOnlySpan<Char> GetRightSubstring() { }

	[CompilerGenerated]
	 void set_Index(int value) { }

	[CompilerGenerated]
	 void set_Length(int value) { }

	[CompilerGenerated]
	 void set_Text(string value) { }

	public virtual string ToString() { }

}

