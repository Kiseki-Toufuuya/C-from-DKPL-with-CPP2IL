namespace System.Xml.Schema;

public class XmlSchemaException : SystemException
{
	private string res; //Field offset: 0x48
	private String[] args; //Field offset: 0x4C
	private string sourceUri; //Field offset: 0x50
	private int lineNumber; //Field offset: 0x54
	private int linePosition; //Field offset: 0x58
	private XmlSchemaObject sourceSchemaObject; //Field offset: 0x5C
	private string message; //Field offset: 0x60

	internal String[] Args
	{
		internal get { } //Length: 11
	}

	internal string GetRes
	{
		internal get { } //Length: 11
	}

	public int LineNumber
	{
		 get { } //Length: 11
	}

	public int LinePosition
	{
		 get { } //Length: 11
	}

	public virtual string Message
	{
		 get { } //Length: 33
	}

	public XmlSchemaObject SourceSchemaObject
	{
		 get { } //Length: 11
	}

	public string SourceUri
	{
		 get { } //Length: 11
	}

	protected XmlSchemaException(SerializationInfo info, StreamingContext context) { }

	internal XmlSchemaException(string res, String[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	internal XmlSchemaException(string res, String[] args, XmlSchemaObject source) { }

	internal XmlSchemaException(string res, XmlSchemaObject source) { }

	internal XmlSchemaException(string res, String[] args, string sourceUri, int lineNumber, int linePosition) { }

	internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition) { }

	internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	internal XmlSchemaException(string res, string arg, XmlSchemaObject source) { }

	internal XmlSchemaException(string res, String[] args) { }

	public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition) { }

	public XmlSchemaException(string message, Exception innerException) { }

	public XmlSchemaException(string message) { }

	public XmlSchemaException() { }

	internal XmlSchemaException(string res, string arg) { }

	internal static string CreateMessage(string res, String[] args) { }

	internal String[] get_Args() { }

	internal string get_GetRes() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public virtual string get_Message() { }

	public XmlSchemaObject get_SourceSchemaObject() { }

	public string get_SourceUri() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void SetSchemaObject(XmlSchemaObject source) { }

	internal void SetSource(XmlSchemaObject source) { }

	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

}

