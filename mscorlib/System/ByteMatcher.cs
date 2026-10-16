namespace System;

internal class ByteMatcher
{
	private Hashtable map; //Field offset: 0x8
	private Hashtable starts; //Field offset: 0xC

	public ByteMatcher() { }

	public void AddMapping(TermInfoStrings key, Byte[] val) { }

	public TermInfoStrings Match(Char[] buffer, int offset, int length, out int used) { }

	public void Sort() { }

	public bool StartsWith(int c) { }

}

