namespace Ionic.Zip;

public class SaveProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesSaved; //Field offset: 0x30

	internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry) { }

	internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor) { }

	internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes) { }

	internal static SaveProgressEventArgs Completed(string archiveName) { }

	internal static SaveProgressEventArgs Started(string archiveName) { }

}

