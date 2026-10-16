namespace System.Xml;

internal class ReaderPositionInfo : PositionInfo
{
	private IXmlLineInfo lineInfo; //Field offset: 0x8

	public virtual int LineNumber
	{
		 get { } //Length: 66
	}

	public virtual int LinePosition
	{
		 get { } //Length: 66
	}

	public ReaderPositionInfo(IXmlLineInfo lineInfo) { }

	public virtual int get_LineNumber() { }

	public virtual int get_LinePosition() { }

	public virtual bool HasLineInfo() { }

}

