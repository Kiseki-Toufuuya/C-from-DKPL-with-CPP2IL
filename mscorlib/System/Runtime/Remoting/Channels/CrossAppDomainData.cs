namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainData
{
	private object _ContextID; //Field offset: 0x8
	private int _DomainID; //Field offset: 0xC
	private string _processGuid; //Field offset: 0x10

	internal int DomainID
	{
		internal get { } //Length: 11
	}

	internal string ProcessID
	{
		internal get { } //Length: 11
	}

	internal CrossAppDomainData(int domainId) { }

	internal int get_DomainID() { }

	internal string get_ProcessID() { }

}

