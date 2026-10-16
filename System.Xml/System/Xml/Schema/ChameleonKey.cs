namespace System.Xml.Schema;

internal class ChameleonKey
{
	internal string targetNS; //Field offset: 0x8
	internal Uri chameleonLocation; //Field offset: 0xC
	internal XmlSchema originalSchema; //Field offset: 0x10
	private int hashCode; //Field offset: 0x14

	public ChameleonKey(string ns, XmlSchema originalSchema) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

