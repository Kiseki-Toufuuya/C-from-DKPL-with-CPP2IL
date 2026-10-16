namespace System.Security.Util;

internal sealed class Parser
{
	private SecurityDocument _doc; //Field offset: 0x8
	private Tokenizer _t; //Field offset: 0xC

	private Parser(Tokenizer t) { }

	internal Parser(string input) { }

	private int DetermineFormat(TokenizerStream stream) { }

	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	internal SecurityElement GetTopElement() { }

	private void ParseContents() { }

}

