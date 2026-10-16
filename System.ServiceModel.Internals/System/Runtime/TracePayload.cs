namespace System.Runtime;

internal struct TracePayload
{
	private string serializedException; //Field offset: 0x0
	private string eventSource; //Field offset: 0x4
	private string appDomainFriendlyName; //Field offset: 0x8
	private string extendedData; //Field offset: 0xC
	private string hostReference; //Field offset: 0x10

	public string AppDomainFriendlyName
	{
		 get { } //Length: 11
	}

	public string EventSource
	{
		 get { } //Length: 11
	}

	public string ExtendedData
	{
		 get { } //Length: 11
	}

	public string SerializedException
	{
		 get { } //Length: 10
	}

	public TracePayload(string serializedException, string eventSource, string appDomainFriendlyName, string extendedData, string hostReference) { }

	public string get_AppDomainFriendlyName() { }

	public string get_EventSource() { }

	public string get_ExtendedData() { }

	public string get_SerializedException() { }

}

