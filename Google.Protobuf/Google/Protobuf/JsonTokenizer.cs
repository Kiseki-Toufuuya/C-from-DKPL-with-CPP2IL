namespace Google.Protobuf;

internal abstract class JsonTokenizer
{
	private class JsonReplayTokenizer : JsonTokenizer
	{
		private readonly IList<JsonToken> tokens; //Field offset: 0x10
		private readonly JsonTokenizer nextTokenizer; //Field offset: 0x14
		private int nextTokenIndex; //Field offset: 0x18

		internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer) { }

		protected virtual JsonToken NextImpl() { }

	}

	private sealed class JsonTextTokenizer : JsonTokenizer
	{
		private enum ContainerType
		{
			Document = 0,
			Object = 1,
			Array = 2,
		}

		private class PushBackReader
		{
			private readonly TextReader reader; //Field offset: 0x8
			private Nullable<Char> nextChar; //Field offset: 0xC

			internal PushBackReader(TextReader reader) { }

			internal InvalidJsonException CreateException(string message) { }

			internal void PushBack(char c) { }

			internal Nullable<Char> Read() { }

			internal char ReadOrFail(string messageOnFailure) { }

		}

		[Flags]
		private enum State
		{
			StartOfDocument = 1,
			ExpectedEndOfDocument = 2,
			ReaderExhausted = 4,
			ObjectStart = 8,
			ObjectBeforeColon = 16,
			ObjectAfterColon = 32,
			ObjectAfterProperty = 64,
			ObjectAfterComma = 128,
			ArrayStart = 256,
			ArrayAfterValue = 512,
			ArrayAfterComma = 1024,
		}

		private static readonly State ValueStates; //Field offset: 0x0
		private readonly Stack<ContainerType> containerStack; //Field offset: 0x10
		private readonly PushBackReader reader; //Field offset: 0x14
		private State state; //Field offset: 0x18

		private static JsonTextTokenizer() { }

		internal JsonTextTokenizer(TextReader reader) { }

		private Nullable<Char> ConsumeDigits(StringBuilder builder, out int count) { }

		private void ConsumeLiteral(string text) { }

		protected virtual JsonToken NextImpl() { }

		private void PopContainer() { }

		private char ReadEscapedCharacter() { }

		private Nullable<Char> ReadExp(StringBuilder builder) { }

		private Nullable<Char> ReadFrac(StringBuilder builder) { }

		private Nullable<Char> ReadInt(StringBuilder builder) { }

		private double ReadNumber(char initialCharacter) { }

		private string ReadString() { }

		private char ReadUnicodeEscape() { }

		private void ValidateAndModifyStateForValue(string errorPrefix) { }

		private void ValidateState(State validStates, string errorPrefix) { }

	}

	private JsonToken bufferedToken; //Field offset: 0x8
	[CompilerGenerated]
	private int <ObjectDepth>k__BackingField; //Field offset: 0xC

	internal int ObjectDepth
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	protected JsonTokenizer() { }

	internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation) { }

	internal static JsonTokenizer FromTextReader(TextReader reader) { }

	[CompilerGenerated]
	internal int get_ObjectDepth() { }

	internal JsonToken Next() { }

	protected abstract JsonToken NextImpl() { }

	internal void PushBack(JsonToken token) { }

	[CompilerGenerated]
	private void set_ObjectDepth(int value) { }

	internal void SkipValue() { }

}

