namespace UnityEngine.ResourceManagement.Exceptions;

public class ProviderException : OperationException
{
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; //Field offset: 0x48

	public IResourceLocation Location
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public ProviderException(string message, IResourceLocation location = null, Exception innerException = null) { }

	[CompilerGenerated]
	public IResourceLocation get_Location() { }

}

