namespace System.Text.RegularExpressions;

internal sealed class ExclusiveReference
{
	private RegexRunner _ref; //Field offset: 0x8
	private RegexRunner _obj; //Field offset: 0xC
	private int _locked; //Field offset: 0x10

	public ExclusiveReference() { }

	public RegexRunner Get() { }

	public void Release(RegexRunner obj) { }

}

