namespace Ionic.Zip;

internal static class SharedUtilities
{
	private static Regex doubleDotRegex1; //Field offset: 0x0
	private static Encoding utf8; //Field offset: 0x4

	private static uint _HRForException(Exception ex1) { }

	private static int _ReadFourBytes(Stream s, string message) { }

	private static SharedUtilities() { }

	public static void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename) { }

	internal static int DateTimeToPacked(DateTime time) { }

	internal static long FindSignature(Stream stream, int SignatureToFind) { }

	public static long GetFileLength(string fileName) { }

	public static string InternalGetTempFileName() { }

	public static string NormalizePathForUseInZipFile(string pathName) { }

	internal static DateTime PackedToDateTime(int packedDateTime) { }

	internal static int ReadEntrySignature(Stream s) { }

	internal static int ReadInt(Stream s) { }

	internal static int ReadSignature(Stream s) { }

	internal static int ReadWithRetry(Stream s, Byte[] buffer, int offset, int count, string FileName) { }

	private static string SimplifyFwdSlashPath(string path) { }

	internal static string StringFromBuffer(Byte[] buf, Encoding encoding) { }

	internal static Byte[] StringToByteArray(string value) { }

	internal static Byte[] StringToByteArray(string value, Encoding encoding) { }

	internal static string Utf8StringFromBuffer(Byte[] buf) { }

}

