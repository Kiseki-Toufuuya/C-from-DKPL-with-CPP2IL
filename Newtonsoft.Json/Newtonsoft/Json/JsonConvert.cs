namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	public static readonly string True; //Field offset: 0x4
	public static readonly string False; //Field offset: 0x8
	public static readonly string Null; //Field offset: 0xC
	public static readonly string Undefined; //Field offset: 0x10
	public static readonly string PositiveInfinity; //Field offset: 0x14
	public static readonly string NegativeInfinity; //Field offset: 0x18
	public static readonly string NaN; //Field offset: 0x1C

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[CompilerGenerated]
		 get { } //Length: 60
	}

	private static JsonConvert() { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureDecimalPlace(string text) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CompilerGenerated]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	public static string ToString(bool value) { }

	public static string ToString(char value) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(decimal value) { }

	public static string ToString(string value) { }

	public static string ToString(string value, char delimiter) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

}

