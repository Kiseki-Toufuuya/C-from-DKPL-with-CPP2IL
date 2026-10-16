//Type is in global namespace

public class AppCustomException : Exception
{
	[CompilerGenerated]
	private AppCustomErrorInfo <LastError>k__BackingField; //Field offset: 0x48

	public AppCustomErrorInfo LastError
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public AppCustomException() { }

	public AppCustomException(AppCustomErrorInfo info) { }

	public AppCustomException(AppCustomErrorInfo info, Exception innerException) { }

	protected AppCustomException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	public AppCustomErrorInfo get_LastError() { }

	[CompilerGenerated]
	public void set_LastError(AppCustomErrorInfo value) { }

}

