namespace System.IO;

[ComVisible(True)]
public class StringWriter : TextWriter
{
	private static UnicodeEncoding m_encoding; //Field offset: 0x0
	private StringBuilder _sb; //Field offset: 0x18
	private bool _isOpen; //Field offset: 0x1C

	public virtual Encoding Encoding
	{
		 get { } //Length: 136
	}

	public StringWriter() { }

	public StringWriter(IFormatProvider formatProvider) { }

	public StringWriter(StringBuilder sb) { }

	public StringWriter(StringBuilder sb, IFormatProvider formatProvider) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Encoding get_Encoding() { }

	public virtual string ToString() { }

	public virtual void Write(char value) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(string value) { }

	[ComVisible(False)]
	public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

}

