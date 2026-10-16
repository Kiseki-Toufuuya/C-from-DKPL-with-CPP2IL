namespace System.Xml.Serialization;

public interface IXmlTextParser
{

	public bool Normalized
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public WhitespaceHandling WhitespaceHandling
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_Normalized() { }

	public WhitespaceHandling get_WhitespaceHandling() { }

	public void set_Normalized(bool value) { }

	public void set_WhitespaceHandling(WhitespaceHandling value) { }

}

