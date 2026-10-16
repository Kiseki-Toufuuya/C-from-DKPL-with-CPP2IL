namespace System.Reflection;

public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; //Field offset: 0x4C

	public Exception[] LoaderExceptions
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual string Message
	{
		 get { } //Length: 20
	}

	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) { }

	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) { }

	private string CreateString(bool isMessage) { }

	[CompilerGenerated]
	public Exception[] get_LoaderExceptions() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

