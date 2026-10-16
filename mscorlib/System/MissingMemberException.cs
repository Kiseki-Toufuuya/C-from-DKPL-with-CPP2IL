namespace System;

public class MissingMemberException : MemberAccessException
{
	protected string ClassName; //Field offset: 0x48
	protected string MemberName; //Field offset: 0x4C
	protected Byte[] Signature; //Field offset: 0x50

	public virtual string Message
	{
		 get { } //Length: 168
	}

	public MissingMemberException() { }

	public MissingMemberException(string message) { }

	protected MissingMemberException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatSignature(Byte[] signature) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

