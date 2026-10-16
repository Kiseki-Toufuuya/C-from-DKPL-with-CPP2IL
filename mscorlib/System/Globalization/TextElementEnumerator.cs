namespace System.Globalization;

[ComVisible(True)]
public class TextElementEnumerator : IEnumerator
{
	private string str; //Field offset: 0x8
	private int index; //Field offset: 0xC
	private int startIndex; //Field offset: 0x10
	private int strLen; //Field offset: 0x14
	private int currTextElementLen; //Field offset: 0x18
	[OptionalField(VersionAdded = 2)]
	private UnicodeCategory uc; //Field offset: 0x1C
	[OptionalField(VersionAdded = 2)]
	private int charLen; //Field offset: 0x20
	private int endIndex; //Field offset: 0x24
	private int nextTextElementLen; //Field offset: 0x28

	public override object Current
	{
		 get { } //Length: 134
	}

	internal TextElementEnumerator(string str, int startIndex, int strLen) { }

	internal TextElementEnumerator() { }

	public override object get_Current() { }

	public string GetTextElement() { }

	public override bool MoveNext() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	public override void Reset() { }

}

