namespace System.Net;

internal class HeaderInfo
{
	internal readonly bool IsRequestRestricted; //Field offset: 0x8
	internal readonly bool IsResponseRestricted; //Field offset: 0x9
	internal readonly HeaderParser Parser; //Field offset: 0xC
	internal readonly string HeaderName; //Field offset: 0x10
	internal readonly bool AllowMultiValues; //Field offset: 0x14

	internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

