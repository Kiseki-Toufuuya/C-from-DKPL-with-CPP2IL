namespace Google.Protobuf;

public sealed class JsonParser
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__39_0(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_1(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_2(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_3(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_4(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_5(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

		internal void <.cctor>b__39_6(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

	}

	internal sealed class Settings
	{
		[CompilerGenerated]
		private static readonly Settings <Default>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <RecursionLimit>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly TypeRegistry <TypeRegistry>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private readonly bool <IgnoreUnknownFields>k__BackingField; //Field offset: 0x10

		public static Settings Default
		{
			[CompilerGenerated]
			 get { } //Length: 60
		}

		public bool IgnoreUnknownFields
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public int RecursionLimit
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public TypeRegistry TypeRegistry
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		private static Settings() { }

		private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields) { }

		public Settings(int recursionLimit) { }

		public Settings(int recursionLimit, TypeRegistry typeRegistry) { }

		[CompilerGenerated]
		public static Settings get_Default() { }

		[CompilerGenerated]
		public bool get_IgnoreUnknownFields() { }

		[CompilerGenerated]
		public int get_RecursionLimit() { }

		[CompilerGenerated]
		public TypeRegistry get_TypeRegistry() { }

		public Settings WithIgnoreUnknownFields(bool ignoreUnknownFields) { }

		public Settings WithRecursionLimit(int recursionLimit) { }

		public Settings WithTypeRegistry(TypeRegistry typeRegistry) { }

	}

	private static readonly Regex TimestampRegex; //Field offset: 0x0
	private static readonly Regex DurationRegex; //Field offset: 0x4
	private static readonly Int32[] SubsecondScalingFactors; //Field offset: 0x8
	private static readonly Char[] FieldMaskPathSeparators; //Field offset: 0xC
	private static readonly JsonParser defaultInstance; //Field offset: 0x10
	private static readonly Dictionary<String, Action`3<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers; //Field offset: 0x14
	private readonly Settings settings; //Field offset: 0x8

	public static JsonParser Default
	{
		 get { } //Length: 61
	}

	private static JsonParser() { }

	public JsonParser(Settings settings) { }

	private static void CheckInteger(double value) { }

	public static JsonParser get_Default() { }

	private static bool IsGoogleProtobufValueField(FieldDescriptor field) { }

	internal void Merge(IMessage message, string json) { }

	internal void Merge(IMessage message, TextReader jsonReader) { }

	private void Merge(IMessage message, JsonTokenizer tokenizer) { }

	private void MergeAny(IMessage message, JsonTokenizer tokenizer) { }

	private static void MergeDuration(IMessage message, JsonToken token) { }

	private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) { }

	private static void MergeFieldMask(IMessage message, JsonToken token) { }

	private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) { }

	private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) { }

	private void MergeStruct(IMessage message, JsonTokenizer tokenizer) { }

	private void MergeStructValue(IMessage message, JsonTokenizer tokenizer) { }

	private static void MergeTimestamp(IMessage message, JsonToken token) { }

	private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer) { }

	private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer) { }

	private static IMessage NewMessageForField(FieldDescriptor field) { }

	public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor) { }

	public IMessage Parse(string json, MessageDescriptor descriptor) { }

	public T Parse(TextReader jsonReader) { }

	public T Parse(string json) { }

	private static object ParseMapKey(FieldDescriptor field, string keyText) { }

	private static T ParseNumericString(string text, Func<String, NumberStyles, IFormatProvider, T> parser) { }

	private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token) { }

	private static object ParseSingleStringValue(FieldDescriptor field, string text) { }

	private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer) { }

	private static string ToSnakeCase(string text) { }

	private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN) { }

}

