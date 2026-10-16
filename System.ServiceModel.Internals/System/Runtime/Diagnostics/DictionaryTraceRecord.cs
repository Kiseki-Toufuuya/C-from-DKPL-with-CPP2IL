namespace System.Runtime.Diagnostics;

internal class DictionaryTraceRecord : TraceRecord
{
	private IDictionary dictionary; //Field offset: 0x8

	internal DictionaryTraceRecord(IDictionary dictionary) { }

	internal virtual void WriteTo(XmlWriter xml) { }

}

