namespace Ionic.Zip;

public class ReadProgressEventArgs : ZipProgressEventArgs
{

	private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor) { }

	internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal) { }

	internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal) { }

	internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes) { }

	internal static ReadProgressEventArgs Completed(string archiveName) { }

	internal static ReadProgressEventArgs Started(string archiveName) { }

}

