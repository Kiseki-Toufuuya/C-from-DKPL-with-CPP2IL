namespace System.Xml.Linq;

public class XDeclaration
{
	private string _version; //Field offset: 0x8
	private string _encoding; //Field offset: 0xC
	private string _standalone; //Field offset: 0x10

	public string Encoding
	{
		 get { } //Length: 11
	}

	public string Standalone
	{
		 get { } //Length: 11
	}

	public string Version
	{
		 get { } //Length: 11
	}

	public XDeclaration(string version, string encoding, string standalone) { }

	public XDeclaration(XDeclaration other) { }

	public string get_Encoding() { }

	public string get_Standalone() { }

	public string get_Version() { }

	public virtual string ToString() { }

}

