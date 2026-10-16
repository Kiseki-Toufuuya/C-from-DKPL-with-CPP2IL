namespace UnityEngine;

public class WWWForm
{
	private static Byte[] dDash; //Field offset: 0x0
	private static Byte[] crlf; //Field offset: 0x4
	private static Byte[] contentTypeHeader; //Field offset: 0x8
	private static Byte[] dispositionHeader; //Field offset: 0xC
	private static Byte[] endQuote; //Field offset: 0x10
	private static Byte[] fileNameField; //Field offset: 0x14
	private static Byte[] ampersand; //Field offset: 0x18
	private static Byte[] equal; //Field offset: 0x1C

	internal static Encoding DefaultEncoding
	{
		internal get { } //Length: 11
	}

	private static WWWForm() { }

	internal static Encoding get_DefaultEncoding() { }

}

