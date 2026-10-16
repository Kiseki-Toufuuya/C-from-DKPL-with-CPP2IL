namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestWWWModule"})]
internal class WWWTranscoder
{
	private static Byte[] ucHexChars; //Field offset: 0x0
	private static Byte[] lcHexChars; //Field offset: 0x4
	private static byte urlEscapeChar; //Field offset: 0x8
	private static Byte[] urlSpace; //Field offset: 0xC
	private static Byte[] dataSpace; //Field offset: 0x10
	private static Byte[] urlForbidden; //Field offset: 0x14
	private static byte qpEscapeChar; //Field offset: 0x18
	private static Byte[] qpSpace; //Field offset: 0x1C
	private static Byte[] qpForbidden; //Field offset: 0x20

	private static WWWTranscoder() { }

	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	public static Byte[] Decode(Byte[] input, byte escapeChar, Byte[] space) { }

	private static byte Hex2Byte(Byte[] b, int offset) { }

	public static Byte[] URLDecode(Byte[] toEncode) { }

}

