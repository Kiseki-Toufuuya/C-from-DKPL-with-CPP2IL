namespace System.Text;

internal struct SurrogateChar
{
	public const int MinValue = 65536; //Field offset: 0x0
	public const int MaxValue = 1114111; //Field offset: 0x0
	private const char surHighMin = '\uD800'; //Field offset: 0x0
	private const char surHighMax = '\uDBFF'; //Field offset: 0x0
	private const char surLowMin = '\uDC00'; //Field offset: 0x0
	private const char surLowMax = '\uDFFF'; //Field offset: 0x0
	private char lowChar; //Field offset: 0x0
	private char highChar; //Field offset: 0x2

	public int Char
	{
		 get { } //Length: 31
	}

	public char HighChar
	{
		 get { } //Length: 12
	}

	public char LowChar
	{
		 get { } //Length: 11
	}

	public SurrogateChar(int ch) { }

	public SurrogateChar(char lowChar, char highChar) { }

	public int get_Char() { }

	public char get_HighChar() { }

	public char get_LowChar() { }

}

