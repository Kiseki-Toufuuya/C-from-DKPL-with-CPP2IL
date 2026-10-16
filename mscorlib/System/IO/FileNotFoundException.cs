namespace System.IO;

public class FileNotFoundException : IOException
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
		 get { } //Length: 180
	}

	public FileNotFoundException() { }

	public FileNotFoundException(string message) { }

	public FileNotFoundException(string message, string fileName) { }

	protected FileNotFoundException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	public string get_FileName() { }

	[CompilerGenerated]
	public string get_FusionLog() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

	public virtual string ToString() { }

}

