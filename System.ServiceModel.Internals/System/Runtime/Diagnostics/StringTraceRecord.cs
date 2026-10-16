namespace System.Runtime.Diagnostics;

internal class StringTraceRecord : TraceRecord
{
	private string elementName; //Field offset: 0x8
	private string content; //Field offset: 0xC

	internal StringTraceRecord(string elementName, string content) { }

	internal virtual void WriteTo(XmlWriter writer) { }

}

