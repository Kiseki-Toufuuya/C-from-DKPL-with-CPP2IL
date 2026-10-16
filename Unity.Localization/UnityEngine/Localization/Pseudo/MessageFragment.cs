namespace UnityEngine.Localization.Pseudo;

[DefaultMember("Item")]
public abstract class MessageFragment
{
	protected string m_OriginalString; //Field offset: 0x8
	protected int m_StartIndex; //Field offset: 0xC
	protected int m_EndIndex; //Field offset: 0x10
	private string m_CachedToString; //Field offset: 0x14
	[CompilerGenerated]
	private Message <Message>k__BackingField; //Field offset: 0x18

	public char Item
	{
		 get { } //Length: 50
	}

	public int Length
	{
		 get { } //Length: 37
	}

	public private Message Message
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	protected MessageFragment() { }

	internal void BuildString(StringBuilder builder) { }

	public ReadOnlyMessageFragment CreateReadonlyTextFragment(int start, int end) { }

	public WritableMessageFragment CreateTextFragment(int start, int end) { }

	public char get_Item(int index) { }

	public int get_Length() { }

	[CompilerGenerated]
	public Message get_Message() { }

	internal void Initialize(Message parent, string original, int start, int end) { }

	internal void Initialize(Message parent, string text) { }

	[CompilerGenerated]
	private void set_Message(Message value) { }

	public virtual string ToString() { }

}

