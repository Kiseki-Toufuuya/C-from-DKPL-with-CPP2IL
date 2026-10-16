namespace System.Security.Util;

internal sealed class TokenizerStream
{
	private int m_countTokens; //Field offset: 0x8
	private TokenizerShortBlock m_headTokens; //Field offset: 0xC
	private TokenizerShortBlock m_lastTokens; //Field offset: 0x10
	private TokenizerShortBlock m_currentTokens; //Field offset: 0x14
	private int m_indexTokens; //Field offset: 0x18
	private TokenizerStringBlock m_headStrings; //Field offset: 0x1C
	private TokenizerStringBlock m_currentStrings; //Field offset: 0x20
	private int m_indexStrings; //Field offset: 0x24

	internal TokenizerStream() { }

	internal void AddString(string str) { }

	internal void AddToken(short token) { }

	internal short GetNextFullToken() { }

	internal string GetNextString() { }

	internal short GetNextToken() { }

	internal int GetTokenCount() { }

	internal void GoToPosition(int position) { }

	internal void Reset() { }

	internal void TagLastToken(short tag) { }

	internal void ThrowAwayNextString() { }

}

