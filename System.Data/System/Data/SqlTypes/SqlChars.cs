namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
{
	internal Char[] _rgchBuf; //Field offset: 0x8
	private long _lCurLen; //Field offset: 0x10
	internal SqlStreamChars _stream; //Field offset: 0x18
	private SqlBytesCharsState _state; //Field offset: 0x1C
	private Char[] _rgchWorkBuf; //Field offset: 0x20

	public Char[] Buffer
	{
		 get { } //Length: 374
	}

	public override bool IsNull
	{
		 get { } //Length: 15
	}

	public long Length
	{
		 get { } //Length: 109
	}

	public static SqlChars Null
	{
		 get { } //Length: 60
	}

	public Char[] Value
	{
		 get { } //Length: 564
	}

	public SqlChars() { }

	public SqlChars(Char[] buffer) { }

	public SqlChars(SqlString value) { }

	private void CopyStreamToBuffer() { }

	internal bool FStream() { }

	public Char[] get_Buffer() { }

	public override bool get_IsNull() { }

	public long get_Length() { }

	public static SqlChars get_Null() { }

	public Char[] get_Value() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private void SetBuffer(Char[] buffer) { }

	public void SetNull() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

