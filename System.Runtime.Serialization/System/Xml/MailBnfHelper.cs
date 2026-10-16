namespace System.Xml;

internal static class MailBnfHelper
{
	private static Boolean[] s_fqtext; //Field offset: 0x0
	private static Boolean[] s_ttext; //Field offset: 0x4
	private static Boolean[] s_digits; //Field offset: 0x8
	private static Boolean[] s_boundary; //Field offset: 0xC

	private static MailBnfHelper() { }

	public static bool IsValidMimeBoundary(string data) { }

	public static string ReadDigits(string data, ref int offset, StringBuilder builder) { }

	public static string ReadParameterAttribute(string data, ref int offset, StringBuilder builder) { }

	public static string ReadParameterValue(string data, ref int offset, StringBuilder builder) { }

	public static string ReadQuotedString(string data, ref int offset, StringBuilder builder) { }

	public static string ReadToken(string data, ref int offset, StringBuilder builder) { }

	public static bool SkipCFWS(string data, ref int offset) { }

}

