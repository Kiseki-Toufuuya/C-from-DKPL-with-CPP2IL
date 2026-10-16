namespace XeSys;

[Extension]
public static class StringExtension
{

	[Extension]
	public static void Clear(StringBuilder str) { }

	public static bool IsNullOrWhiteSpace(string value) { }

	[Extension]
	public static void Set(StringBuilder str, string inputStr) { }

	[Extension]
	public static void Set(StringBuilder str, char inputChar) { }

	[Extension]
	public static void SetFormat(StringBuilder str, string format, object arg0) { }

	[Extension]
	public static void SetFormat(StringBuilder str, string format, object arg0, object arg1) { }

	[Extension]
	public static void SetFormat(StringBuilder str, string format, object arg0, object arg1, object arg2) { }

	[Extension]
	public static void SetFormat(StringBuilder str, string format, Object[] args) { }

}

