namespace System.Xml;

public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
{
	private struct NamespaceDeclaration
	{
		public string prefix; //Field offset: 0x0
		public string uri; //Field offset: 0x4
		public int scopeId; //Field offset: 0x8
		public int previousNsIndex; //Field offset: 0xC

		public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

	}

	private NamespaceDeclaration[] nsdecls; //Field offset: 0x8
	private int lastDecl; //Field offset: 0xC
	private XmlNameTable nameTable; //Field offset: 0x10
	private int scopeId; //Field offset: 0x14
	private Dictionary<String, Int32> hashTable; //Field offset: 0x18
	private bool useHashtable; //Field offset: 0x1C
	private string xml; //Field offset: 0x20
	private string xmlNs; //Field offset: 0x24

	public override string DefaultNamespace
	{
		 get { } //Length: 55
	}

	public override XmlNameTable NameTable
	{
		 get { } //Length: 11
	}

	internal XmlNamespaceManager() { }

	public XmlNamespaceManager(XmlNameTable nameTable) { }

	public override void AddNamespace(string prefix, string uri) { }

	public override string get_DefaultNamespace() { }

	public override XmlNameTable get_NameTable() { }

	public override IEnumerator GetEnumerator() { }

	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	public override string LookupNamespace(string prefix) { }

	private int LookupNamespaceDecl(string prefix) { }

	public override string LookupPrefix(string uri) { }

	public override bool PopScope() { }

	public override void PushScope() { }

	public override void RemoveNamespace(string prefix, string uri) { }

}

