namespace Internal.Cryptography;

[Extension]
internal static class Helpers
{

	[Extension]
	public static Byte[] CloneByteArray(Byte[] src) { }

	public static Byte[] GenerateRandom(int count) { }

	private static char NibbleToHex(byte b) { }

	[Extension]
	public static Char[] ToHexArrayUpper(Byte[] bytes) { }

	[Extension]
	public static string ToHexStringUpper(Byte[] bytes) { }

	public static void WriteInt(uint i, Byte[] arr, int offset) { }

}

