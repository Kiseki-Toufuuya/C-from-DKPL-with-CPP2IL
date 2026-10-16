namespace UnityEngine.Localization.SmartFormat;

[Extension]
public static class SmartExtensions
{

	[Extension]
	public static void AppendLineSmart(StringBuilder sb, string format, Object[] args) { }

	[Extension]
	public static void AppendSmart(StringBuilder sb, string format, Object[] args) { }

	[Extension]
	public static string FormatSmart(string format, Object[] args) { }

	[Extension]
	public static string FormatSmart(string format, ref FormatCache cache, Object[] args) { }

	[Extension]
	public static void WriteLineSmart(TextWriter writer, string format, Object[] args) { }

	[Extension]
	public static void WriteSmart(TextWriter writer, string format, Object[] args) { }

}

