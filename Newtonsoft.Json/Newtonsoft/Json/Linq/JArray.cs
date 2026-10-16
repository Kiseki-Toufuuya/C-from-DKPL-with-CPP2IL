namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
{
	private readonly List<JToken> _values; //Field offset: 0x28

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 11
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 240
		 set { } //Length: 242
	}

	public override JToken Item
	{
		 get { } //Length: 31
		 set { } //Length: 34
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JArray() { }

	internal JArray(JArray other, JsonCloneSettings settings) { }

	public JArray(object content) { }

	public override void Add(JToken item) { }

	public override void Clear() { }

	internal virtual JToken CloneToken(JsonCloneSettings settings = null) { }

	public override bool Contains(JToken item) { }

	public override void CopyTo(JToken[] array, int arrayIndex) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public override bool get_IsReadOnly() { }

	public override JToken get_Item(int index) { }

	public virtual JToken get_Item(object key) { }

	public virtual JTokenType get_Type() { }

	public override IEnumerator<JToken> GetEnumerator() { }

	public override int IndexOf(JToken item) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	public override void Insert(int index, JToken item) { }

	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	public override bool Remove(JToken item) { }

	public override void RemoveAt(int index) { }

	public virtual void set_Item(object key, JToken value) { }

	public override void set_Item(int index, JToken value) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

