namespace System.Xml;

internal sealed class XmlChildEnumerator : IEnumerator
{
	internal XmlNode container; //Field offset: 0x8
	internal XmlNode child; //Field offset: 0xC
	internal bool isFirst; //Field offset: 0x10

	internal XmlNode Current
	{
		internal get { } //Length: 97
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 97
	}

	internal XmlChildEnumerator(XmlNode container) { }

	internal XmlNode get_Current() { }

	internal bool MoveNext() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

