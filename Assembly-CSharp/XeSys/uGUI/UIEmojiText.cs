namespace XeSys.uGUI;

public class UIEmojiText : Text
{
	[CompilerGenerated]
	private sealed class <Co_MakeEmojiText>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIEmojiText <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_MakeEmojiText>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct EmojiInfo
	{
		public int textPosition; //Field offset: 0x0
		public string key; //Field offset: 0x4

		public EmojiInfo(int _posi, string _key) { }

	}

	private static char EM_SPACE; //Field offset: 0x0
	private static UIEmojiTextData sEmojiData; //Field offset: 0x4
	private static Dictionary<String, Sprite> sDicEmojiSprite; //Field offset: 0x8
	public static int EmojiCodeLength; //Field offset: 0xC
	public static char EmojiStartCode; //Field offset: 0x10
	public static char EmojiEndCode; //Field offset: 0x12
	public static string EmojiDataPath; //Field offset: 0x14
	private List<UIVertex> mVertices; //Field offset: 0x9C
	private List<EmojiInfo> mEmojiInfoList; //Field offset: 0xA0
	private bool mIsDelaySetup; //Field offset: 0xA4

	private static Dictionary<String, Sprite> dic
	{
		private get { } //Length: 130
	}

	private static UIEmojiTextData emojiData
	{
		private get { } //Length: 334
	}

	public virtual string text
	{
		 get { } //Length: 14
		 set { } //Length: 106
	}

	private static UIEmojiText() { }

	public UIEmojiText() { }

	[CompilerGenerated]
	private bool <Co_MakeEmojiText>b__19_0() { }

	[IteratorStateMachine(typeof(<Co_MakeEmojiText>d__19))]
	private IEnumerator Co_MakeEmojiText() { }

	private static Dictionary<String, Sprite> get_dic() { }

	private static UIEmojiTextData get_emojiData() { }

	public virtual string get_text() { }

	private void HideOldEmojis(int start) { }

	private void MakeEmojiText() { }

	private static void MakeSpriteDictionary() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	private string ParseText(string _text) { }

	public static void RegisterData(UIEmojiTextData _data) { }

	public virtual void set_text(string value) { }

	public static void UnregisterData() { }

}

