namespace UnityEngine.Localization.Pseudo;

public class Message
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Message <.cctor>b__21_0() { }

	}

	internal static readonly ObjectPool<Message> Pool; //Field offset: 0x0
	[CompilerGenerated]
	private string <Original>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private List<MessageFragment> <Fragments>k__BackingField; //Field offset: 0xC

	public private List<MessageFragment> Fragments
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public int Length
	{
		 get { } //Length: 352
	}

	public private string Original
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private static Message() { }

	public Message() { }

	internal static Message CreateMessage(string text) { }

	public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original, int start, int end) { }

	public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original) { }

	public WritableMessageFragment CreateTextFragment(string original, int start, int end) { }

	public WritableMessageFragment CreateTextFragment(string original) { }

	[CompilerGenerated]
	public List<MessageFragment> get_Fragments() { }

	public int get_Length() { }

	[CompilerGenerated]
	public string get_Original() { }

	internal void Release() { }

	public void ReleaseFragment(MessageFragment fragment) { }

	public void ReplaceFragment(MessageFragment original, MessageFragment replacement) { }

	[CompilerGenerated]
	private void set_Fragments(List<MessageFragment> value) { }

	[CompilerGenerated]
	private void set_Original(string value) { }

	public virtual string ToString() { }

}

