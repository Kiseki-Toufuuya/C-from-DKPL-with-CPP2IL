namespace System.Xml;

public sealed class XmlDictionaryReaderQuotas
{
	private const int DefaultMaxDepth = 32; //Field offset: 0x0
	private const int DefaultMaxStringContentLength = 8192; //Field offset: 0x0
	private const int DefaultMaxArrayLength = 16384; //Field offset: 0x0
	private const int DefaultMaxBytesPerRead = 4096; //Field offset: 0x0
	private const int DefaultMaxNameTableCharCount = 16384; //Field offset: 0x0
	private static XmlDictionaryReaderQuotas defaultQuota; //Field offset: 0x0
	private static XmlDictionaryReaderQuotas maxQuota; //Field offset: 0x4
	private bool readOnly; //Field offset: 0x8
	private int maxStringContentLength; //Field offset: 0xC
	private int maxArrayLength; //Field offset: 0x10
	private int maxDepth; //Field offset: 0x14
	private int maxNameTableCharCount; //Field offset: 0x18
	private int maxBytesPerRead; //Field offset: 0x1C
	private XmlDictionaryReaderQuotaTypes modifiedQuotas; //Field offset: 0x20

	public static XmlDictionaryReaderQuotas Max
	{
		 get { } //Length: 61
	}

	[DefaultValue(16384)]
	public int MaxArrayLength
	{
		 get { } //Length: 11
		 set { } //Length: 283
	}

	[DefaultValue(4096)]
	public int MaxBytesPerRead
	{
		 get { } //Length: 11
		 set { } //Length: 283
	}

	[DefaultValue(32)]
	public int MaxDepth
	{
		 get { } //Length: 11
		 set { } //Length: 283
	}

	[DefaultValue(16384)]
	public int MaxNameTableCharCount
	{
		 get { } //Length: 11
		 set { } //Length: 283
	}

	[DefaultValue(8192)]
	public int MaxStringContentLength
	{
		 get { } //Length: 11
		 set { } //Length: 283
	}

	public XmlDictionaryReaderQuotaTypes ModifiedQuotas
	{
		 get { } //Length: 11
	}

	private static XmlDictionaryReaderQuotas() { }

	public XmlDictionaryReaderQuotas() { }

	private XmlDictionaryReaderQuotas(int maxDepth, int maxStringContentLength, int maxArrayLength, int maxBytesPerRead, int maxNameTableCharCount, XmlDictionaryReaderQuotaTypes modifiedQuotas) { }

	public void CopyTo(XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReaderQuotas get_Max() { }

	public int get_MaxArrayLength() { }

	public int get_MaxBytesPerRead() { }

	public int get_MaxDepth() { }

	public int get_MaxNameTableCharCount() { }

	public int get_MaxStringContentLength() { }

	public XmlDictionaryReaderQuotaTypes get_ModifiedQuotas() { }

	internal void InternalCopyTo(XmlDictionaryReaderQuotas quotas) { }

	internal void MakeReadOnly() { }

	public void set_MaxArrayLength(int value) { }

	public void set_MaxBytesPerRead(int value) { }

	public void set_MaxDepth(int value) { }

	public void set_MaxNameTableCharCount(int value) { }

	public void set_MaxStringContentLength(int value) { }

}

