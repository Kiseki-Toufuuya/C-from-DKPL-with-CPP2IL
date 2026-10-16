namespace System.Xml.Schema;

internal class Asttree
{
	private ArrayList _fAxisArray; //Field offset: 0x8
	private string _xpathexpr; //Field offset: 0xC
	private bool _isField; //Field offset: 0x10
	private XmlNamespaceManager _nsmgr; //Field offset: 0x14

	internal ArrayList SubtreeArray
	{
		internal get { } //Length: 11
	}

	public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	internal ArrayList get_SubtreeArray() { }

	internal static bool IsAttribute(Axis ast) { }

	private static bool IsDescendantOrSelf(Axis ast) { }

	private static bool IsNameTest(Axis ast) { }

	internal static bool IsSelf(Axis ast) { }

	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

