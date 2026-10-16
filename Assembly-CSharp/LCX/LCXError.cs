namespace LCX;

public class LCXError : Exception
{
	internal enum ErrorType
	{
		CANCEL = 0,
		NETWORK_ERROR = 1,
		SIGN_IN_REQUIRED = 2,
		SYSTEM_ERROR = 3,
	}

	[CompilerGenerated]
	private readonly string <ErrorCode>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <ErrorMessage>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly ErrorType <ErrorTypeInfo>k__BackingField; //Field offset: 0x50

	public string ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public ErrorType ErrorTypeInfo
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public LCXError(string msg, ErrorType err, string code) { }

	[CompilerGenerated]
	public string get_ErrorCode() { }

	[CompilerGenerated]
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	public ErrorType get_ErrorTypeInfo() { }

}

