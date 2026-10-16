namespace System.Text.RegularExpressions;

public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; //Field offset: 0x50

	public string Input
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public TimeSpan MatchTimeout
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public string Pattern
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	public RegexMatchTimeoutException() { }

	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	public string get_Input() { }

	[CompilerGenerated]
	public TimeSpan get_MatchTimeout() { }

	[CompilerGenerated]
	public string get_Pattern() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

