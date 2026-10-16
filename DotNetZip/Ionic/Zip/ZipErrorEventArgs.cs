namespace Ionic.Zip;

public class ZipErrorEventArgs : ZipProgressEventArgs
{
	private Exception _exc; //Field offset: 0x30

	private ZipErrorEventArgs() { }

	internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception) { }

}

