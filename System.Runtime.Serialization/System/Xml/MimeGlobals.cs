namespace System.Xml;

internal static class MimeGlobals
{
	internal static string MimeVersionHeader; //Field offset: 0x0
	internal static string DefaultVersion; //Field offset: 0x4
	internal static string ContentIDScheme; //Field offset: 0x8
	internal static string ContentIDHeader; //Field offset: 0xC
	internal static string ContentTypeHeader; //Field offset: 0x10
	internal static string ContentTransferEncodingHeader; //Field offset: 0x14
	internal static string EncodingBinary; //Field offset: 0x18
	internal static string Encoding8bit; //Field offset: 0x1C
	internal static Byte[] COLONSPACE; //Field offset: 0x20
	internal static Byte[] DASHDASH; //Field offset: 0x24
	internal static Byte[] CRLF; //Field offset: 0x28
	internal static Byte[] BoundaryPrefix; //Field offset: 0x2C

	private static MimeGlobals() { }

}

