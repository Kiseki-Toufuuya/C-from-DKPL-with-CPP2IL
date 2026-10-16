namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class StringDictionary : IEnumerable
{
	internal Hashtable contents; //Field offset: 0x8

	public StringDictionary() { }

	public override IEnumerator GetEnumerator() { }

}

