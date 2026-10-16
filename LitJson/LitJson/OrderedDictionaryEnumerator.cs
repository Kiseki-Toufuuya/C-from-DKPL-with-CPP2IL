namespace LitJson;

internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
{
	private IEnumerator<KeyValuePair`2<String, JsonData>> list_enumerator; //Field offset: 0x8

	public override object Current
	{
		 get { } //Length: 168
	}

	public override DictionaryEntry Entry
	{
		 get { } //Length: 118
	}

	public override object Key
	{
		 get { } //Length: 76
	}

	public override object Value
	{
		 get { } //Length: 83
	}

	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair`2<String, JsonData>> enumerator) { }

	public override object get_Current() { }

	public override DictionaryEntry get_Entry() { }

	public override object get_Key() { }

	public override object get_Value() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

