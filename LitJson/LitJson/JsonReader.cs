namespace LitJson;

public class JsonReader
{
	private static readonly IDictionary<Int32, IDictionary`2<Int32, Int32[]>> parse_table; //Field offset: 0x0
	private Stack<Int32> automaton_stack; //Field offset: 0x8
	private int current_input; //Field offset: 0xC
	private int current_symbol; //Field offset: 0x10
	private bool end_of_json; //Field offset: 0x14
	private bool end_of_input; //Field offset: 0x15
	private Lexer lexer; //Field offset: 0x18
	private bool parser_in_string; //Field offset: 0x1C
	private bool parser_return; //Field offset: 0x1D
	private bool read_started; //Field offset: 0x1E
	private TextReader reader; //Field offset: 0x20
	private bool reader_is_owned; //Field offset: 0x24
	private bool skip_non_members; //Field offset: 0x25
	private object token_value; //Field offset: 0x28
	private JsonToken token; //Field offset: 0x2C

	public bool AllowComments
	{
		 get { } //Length: 23
		 set { } //Length: 26
	}

	public bool AllowSingleQuotedStrings
	{
		 get { } //Length: 23
		 set { } //Length: 26
	}

	public bool EndOfInput
	{
		 get { } //Length: 11
	}

	public bool EndOfJson
	{
		 get { } //Length: 11
	}

	public bool SkipNonMembers
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public JsonToken Token
	{
		 get { } //Length: 11
	}

	public object Value
	{
		 get { } //Length: 11
	}

	private static JsonReader() { }

	private JsonReader(TextReader reader, bool owned) { }

	public JsonReader(TextReader reader) { }

	public JsonReader(string json_text) { }

	public void Close() { }

	public bool get_AllowComments() { }

	public bool get_AllowSingleQuotedStrings() { }

	public bool get_EndOfInput() { }

	public bool get_EndOfJson() { }

	public bool get_SkipNonMembers() { }

	public JsonToken get_Token() { }

	public object get_Value() { }

	private static IDictionary<Int32, IDictionary`2<Int32, Int32[]>> PopulateParseTable() { }

	private void ProcessNumber(string number) { }

	private void ProcessSymbol() { }

	public bool Read() { }

	private bool ReadToken() { }

	public void set_AllowComments(bool value) { }

	public void set_AllowSingleQuotedStrings(bool value) { }

	public void set_SkipNonMembers(bool value) { }

	private static void TableAddCol(IDictionary<Int32, IDictionary`2<Int32, Int32[]>> parse_table, ParserToken row, int col, Int32[] symbols) { }

	private static void TableAddRow(IDictionary<Int32, IDictionary`2<Int32, Int32[]>> parse_table, ParserToken rule) { }

}

