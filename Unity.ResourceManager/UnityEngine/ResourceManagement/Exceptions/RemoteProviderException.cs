namespace UnityEngine.ResourceManagement.Exceptions;

public class RemoteProviderException : ProviderException
{
	[CompilerGenerated]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; //Field offset: 0x4C

	public virtual string Message
	{
		 get { } //Length: 28
	}

	public UnityWebRequestResult WebRequestResult
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public RemoteProviderException(string message, IResourceLocation location = null, UnityWebRequestResult uwrResult = null, Exception innerException = null) { }

	public virtual string get_Message() { }

	[CompilerGenerated]
	public UnityWebRequestResult get_WebRequestResult() { }

	public virtual string ToString() { }

}

