namespace System.IO;

public sealed class FileInfo : FileSystemInfo
{

	public long Length
	{
		 get { } //Length: 125
	}

	public virtual string Name
	{
		 get { } //Length: 11
	}

	private FileInfo() { }

	public FileInfo(string fileName) { }

	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	private FileInfo(SerializationInfo info, StreamingContext context) { }

	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	public long get_Length() { }

	public virtual string get_Name() { }

}

