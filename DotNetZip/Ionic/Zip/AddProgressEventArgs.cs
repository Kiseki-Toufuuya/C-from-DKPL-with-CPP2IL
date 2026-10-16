namespace Ionic.Zip;

public class AddProgressEventArgs : ZipProgressEventArgs
{

	private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor) { }

	internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal) { }

	internal static AddProgressEventArgs Completed(string archiveName) { }

	internal static AddProgressEventArgs Started(string archiveName) { }

}

