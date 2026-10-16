namespace UnityEngine.Localization.Pseudo;

[DebuggerDisplay("ReadOnly: {Text}")]
public class ReadOnlyMessageFragment : MessageFragment
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ReadOnlyMessageFragment <.cctor>b__4_0() { }

	}

	internal static readonly ObjectPool<ReadOnlyMessageFragment> Pool; //Field offset: 0x0

	public string Text
	{
		 get { } //Length: 28
	}

	private static ReadOnlyMessageFragment() { }

	public ReadOnlyMessageFragment() { }

	public string get_Text() { }

}

