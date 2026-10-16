namespace System.Xml.XPath;

public class XPathException : SystemException
{
	private string res; //Field offset: 0x48
	private String[] args; //Field offset: 0x4C
	private string message; //Field offset: 0x50

	public virtual string Message
	{
		 get { } //Length: 33
	}

	protected XPathException(SerializationInfo info, StreamingContext context) { }

	public XPathException() { }

	public XPathException(string message, Exception innerException) { }

	private XPathException(string res, String[] args) { }

	private XPathException(string res, String[] args, Exception inner) { }

	internal static XPathException Create(string res) { }

	internal static XPathException Create(string res, string arg) { }

	internal static XPathException Create(string res, string arg, string arg2) { }

	private static string CreateMessage(string res, String[] args) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

