namespace LitJson;

public class JsonWriter
{
	private static readonly NumberFormatInfo number_format; //Field offset: 0x0
	private WriterContext context; //Field offset: 0x8
	private Stack<WriterContext> ctx_stack; //Field offset: 0xC
	private bool has_reached_end; //Field offset: 0x10
	private Char[] hex_seq; //Field offset: 0x14
	private int indentation; //Field offset: 0x18
	private int indent_value; //Field offset: 0x1C
	private StringBuilder inst_string_builder; //Field offset: 0x20
	private bool pretty_print; //Field offset: 0x24
	private bool validate; //Field offset: 0x25
	private bool lower_case_properties; //Field offset: 0x26
	private TextWriter writer; //Field offset: 0x28

	public int IndentValue
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public bool LowerCaseProperties
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool PrettyPrint
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public TextWriter TextWriter
	{
		 get { } //Length: 11
	}

	public bool Validate
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static JsonWriter() { }

	public JsonWriter() { }

	public JsonWriter(StringBuilder sb) { }

	public JsonWriter(TextWriter writer) { }

	private void DoValidation(Condition cond) { }

	public int get_IndentValue() { }

	public bool get_LowerCaseProperties() { }

	public bool get_PrettyPrint() { }

	public TextWriter get_TextWriter() { }

	public bool get_Validate() { }

	private void Indent() { }

	private void Init() { }

	private static void IntToHex(int n, Char[] hex) { }

	private void Put(string str) { }

	private void PutNewline(bool add_comma) { }

	private void PutNewline() { }

	private void PutString(string str) { }

	public void Reset() { }

	public void set_IndentValue(int value) { }

	public void set_LowerCaseProperties(bool value) { }

	public void set_PrettyPrint(bool value) { }

	public void set_Validate(bool value) { }

	public virtual string ToString() { }

	private void Unindent() { }

	[CLSCompliant(False)]
	public void Write(ulong number) { }

	public void Write(string str) { }

	public void Write(long number) { }

	public void Write(int number) { }

	public void Write(double number) { }

	public void Write(decimal number) { }

	public void Write(bool boolean) { }

	public void Write(float number) { }

	public void WriteArrayEnd() { }

	public void WriteArrayStart() { }

	public void WriteObjectEnd() { }

	public void WriteObjectStart() { }

	public void WritePropertyName(string property_name) { }

}

