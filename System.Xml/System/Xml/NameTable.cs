namespace System.Xml;

public class NameTable : XmlNameTable
{
	private class Entry
	{
		internal string str; //Field offset: 0x8
		internal int hashCode; //Field offset: 0xC
		internal Entry next; //Field offset: 0x10

		internal Entry(string str, int hashCode, Entry next) { }

	}

	private Entry[] entries; //Field offset: 0x8
	private int count; //Field offset: 0xC
	private int mask; //Field offset: 0x10
	private int hashCodeRandomizer; //Field offset: 0x14

	public NameTable() { }

	public virtual string Add(string key) { }

	public virtual string Add(Char[] key, int start, int len) { }

	private string AddEntry(string str, int hashCode) { }

	public virtual string Get(string value) { }

	public virtual string Get(Char[] key, int start, int len) { }

	private void Grow() { }

	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

