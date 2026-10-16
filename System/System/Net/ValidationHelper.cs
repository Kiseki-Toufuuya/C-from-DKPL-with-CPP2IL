namespace System.Net;

internal static class ValidationHelper
{
	public static String[] EmptyArray; //Field offset: 0x0
	internal static readonly Char[] InvalidMethodChars; //Field offset: 0x4
	internal static readonly Char[] InvalidParamChars; //Field offset: 0x8

	private static ValidationHelper() { }

	public static bool IsBlankString(string stringValue) { }

	public static string MakeStringNull(string stringValue) { }

	public static bool ValidateTcpPort(int port) { }

}

