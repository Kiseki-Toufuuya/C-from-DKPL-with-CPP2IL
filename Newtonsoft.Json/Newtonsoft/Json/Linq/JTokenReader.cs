namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JTokenReader : JsonReader, IJsonLineInfo
{
	private readonly JToken _root; //Field offset: 0x50
	[Nullable(2)]
	private string _initialPath; //Field offset: 0x54
	[Nullable(2)]
	private JToken _parent; //Field offset: 0x58
	[Nullable(2)]
	private JToken _current; //Field offset: 0x5C

	[Nullable(2)]
	public JToken CurrentToken
	{
		[NullableContext(2)]
		 get { } //Length: 11
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 71
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 71
	}

	public virtual string Path
	{
		 get { } //Length: 192
	}

	public JTokenReader(JToken token) { }

	[NullableContext(2)]
	public JToken get_CurrentToken() { }

	public virtual string get_Path() { }

	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	public virtual bool Read() { }

	private bool ReadInto(JContainer c) { }

	private bool ReadOver(JToken t) { }

	private bool ReadToEnd() { }

	[NullableContext(2)]
	private string SafeToString(object value) { }

	private bool SetEnd(JContainer c) { }

	private void SetToken(JToken token) { }

}

