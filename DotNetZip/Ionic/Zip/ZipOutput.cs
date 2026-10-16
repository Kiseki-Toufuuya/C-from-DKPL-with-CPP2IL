namespace Ionic.Zip;

internal static class ZipOutput
{

	private static int CountEntries(ICollection<ZipEntry> _entries) { }

	private static Byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container) { }

	private static Byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments) { }

	private static Encoding GetEncoding(ZipContainer container, string t) { }

	public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container) { }

}

