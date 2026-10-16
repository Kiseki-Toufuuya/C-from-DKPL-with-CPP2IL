namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class SymbolsDictionary
{
	private int last; //Field offset: 0x8
	private Hashtable names; //Field offset: 0xC
	private Hashtable wildcards; //Field offset: 0x10
	private ArrayList particles; //Field offset: 0x14
	private object particleLast; //Field offset: 0x18
	private bool isUpaEnforced; //Field offset: 0x1C

	public int Count
	{
		 get { } //Length: 12
	}

	public bool IsUpaEnforced
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int Item
	{
		 get { } //Length: 154
	}

	public SymbolsDictionary() { }

	public int AddName(XmlQualifiedName name, object particle) { }

	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	private void AddWildcard(string wildcard, object particle) { }

	public bool Exists(XmlQualifiedName name) { }

	public int get_Count() { }

	public bool get_IsUpaEnforced() { }

	public int get_Item(XmlQualifiedName name) { }

	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	public object GetParticle(int symbol) { }

	public string NameOf(int symbol) { }

	public void set_IsUpaEnforced(bool value) { }

}

