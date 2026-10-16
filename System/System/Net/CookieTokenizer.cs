namespace System.Net;

internal class CookieTokenizer
{
	private struct RecognizedAttribute
	{
		private string m_name; //Field offset: 0x0
		private CookieToken m_token; //Field offset: 0x4

		internal CookieToken Token
		{
			internal get { } //Length: 11
		}

		internal RecognizedAttribute(string name, CookieToken token) { }

		internal CookieToken get_Token() { }

		internal bool IsEqualTo(string value) { }

	}

	private static RecognizedAttribute[] RecognizedAttributes; //Field offset: 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; //Field offset: 0x4
	private bool m_eofCookie; //Field offset: 0x8
	private int m_index; //Field offset: 0xC
	private int m_length; //Field offset: 0x10
	private string m_name; //Field offset: 0x14
	private bool m_quoted; //Field offset: 0x18
	private int m_start; //Field offset: 0x1C
	private CookieToken m_token; //Field offset: 0x20
	private int m_tokenLength; //Field offset: 0x24
	private string m_tokenStream; //Field offset: 0x28
	private string m_value; //Field offset: 0x2C

	internal bool EndOfCookie
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool Eof
	{
		internal get { } //Length: 17
	}

	internal string Name
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal bool Quoted
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal CookieToken Token
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal string Value
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	private static CookieTokenizer() { }

	internal CookieTokenizer(string tokenStream) { }

	internal string Extract() { }

	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	internal bool get_EndOfCookie() { }

	internal bool get_Eof() { }

	internal string get_Name() { }

	internal bool get_Quoted() { }

	internal CookieToken get_Token() { }

	internal string get_Value() { }

	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	internal void Reset() { }

	internal void set_EndOfCookie(bool value) { }

	internal void set_Name(string value) { }

	internal void set_Quoted(bool value) { }

	internal void set_Token(CookieToken value) { }

	internal void set_Value(string value) { }

	internal CookieToken TokenFromName(bool parseResponseCookies) { }

}

