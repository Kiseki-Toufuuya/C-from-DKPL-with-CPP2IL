namespace System.IO;

public sealed class DirectoryInfo : FileSystemInfo
{

	public DirectoryInfo(string path) { }

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	public DirectoryInfo[] GetDirectories() { }

	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	public FileInfo[] GetFiles() { }

	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

}

