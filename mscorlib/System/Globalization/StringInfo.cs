namespace System.Globalization;

[ComVisible(True)]
public class StringInfo
{
	[OptionalField(VersionAdded = 2)]
	private string m_str; //Field offset: 0x8
	private Int32[] m_indexes; //Field offset: 0xC

	private Int32[] Indexes
	{
		private get { } //Length: 273
	}

	public int LengthInTextElements
	{
		 get { } //Length: 51
	}

	public string String
	{
		 get { } //Length: 11
		 set { } //Length: 140
	}

	public StringInfo() { }

	public StringInfo(string value) { }

	[ComVisible(False)]
	public virtual bool Equals(object value) { }

	private Int32[] get_Indexes() { }

	public int get_LengthInTextElements() { }

	public string get_String() { }

	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	public static Int32[] ParseCombiningCharacters(string str) { }

	public void set_String(string value) { }

}

