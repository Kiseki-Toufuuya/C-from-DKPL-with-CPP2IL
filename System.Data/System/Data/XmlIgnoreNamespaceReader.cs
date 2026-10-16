namespace System.Data;

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
{
	private List<String> _namespacesToIgnore; //Field offset: 0x20

	internal XmlIgnoreNamespaceReader(XmlDocument xdoc, String[] namespacesToIgnore) { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

}

