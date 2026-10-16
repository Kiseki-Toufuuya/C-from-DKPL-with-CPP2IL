namespace System.IO;

public class FileLoadException : IOException
{
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; //Field offset: 0x4C

	public string FileName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string FusionLog
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual string Message
	{
		 get { } //Length: 107
	}

	public FileLoadException() { }

	public FileLoadException(string message) { }

	protected FileLoadException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

	[CompilerGenerated]
	public string get_FileName() { }

	[CompilerGenerated]
	public string get_FusionLog() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

