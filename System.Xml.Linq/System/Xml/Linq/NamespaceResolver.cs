namespace System.Xml.Linq;

internal struct NamespaceResolver
{
	private class NamespaceDeclaration
	{
		public string prefix; //Field offset: 0x8
		public XNamespace ns; //Field offset: 0xC
		public int scope; //Field offset: 0x10
		public NamespaceDeclaration prev; //Field offset: 0x14

		public NamespaceDeclaration() { }

	}

	private int _scope; //Field offset: 0x0
	private NamespaceDeclaration _declaration; //Field offset: 0x4
	private NamespaceDeclaration _rover; //Field offset: 0x8

	public void Add(string prefix, XNamespace ns) { }

	public void AddFirst(string prefix, XNamespace ns) { }

	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	public void PopScope() { }

	public void PushScope() { }

}

