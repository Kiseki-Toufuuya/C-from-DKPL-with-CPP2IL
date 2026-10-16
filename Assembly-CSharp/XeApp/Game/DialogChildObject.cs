namespace XeApp.Game;

public class DialogChildObject : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public RawImage image; //Field offset: 0x8

		public <>c__DisplayClass15_0() { }

		internal void <LoadItemImage>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public RawImage image1; //Field offset: 0x8

		public <>c__DisplayClass16_0() { }

		internal void <LoadImage>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public RawImageEx image; //Field offset: 0x8

		public <>c__DisplayClass17_0() { }

		internal void <LoadCharacterThumbnailImage>b__0(AssetBundleLoadAssetOperation op) { }

	}

	[CompilerGenerated]
	private sealed class <FadeAlpha>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RawImageEx image; //Field offset: 0x10
		private float <time>5__2; //Field offset: 0x14
		private float <fadeTime>5__3; //Field offset: 0x18

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
		public <FadeAlpha>d__18(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <LoadCharacterThumbnailImage>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public List<RawImageEx> images; //Field offset: 0x10
		public DialogChildObject <>4__this; //Field offset: 0x14
		private <>c__DisplayClass17_0 <>8__1; //Field offset: 0x18
		private int <i>5__2; //Field offset: 0x1C
		private AssetBundleLoadAssetOperation <operation>5__3; //Field offset: 0x20

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
		public <LoadCharacterThumbnailImage>d__17(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <LoadImage>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RawImage image1; //Field offset: 0x10
		public string imagePath; //Field offset: 0x14
		private <>c__DisplayClass16_0 <>8__1; //Field offset: 0x18
		private AssetBundleLoadAssetOperation <reqItem>5__2; //Field offset: 0x1C

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
		public <LoadImage>d__16(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <LoadItemImage>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DialogChildParameter param; //Field offset: 0x10
		public DialogChildObject <>4__this; //Field offset: 0x14
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x18
		private int <i>5__2; //Field offset: 0x1C
		private AssetBundleLoadAssetOperation <reqItem>5__3; //Field offset: 0x20

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
		public <LoadItemImage>d__15(int <>1__state) { }

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

	private enum EPCharaDispType
	{
		ABC = 0,
		ACB = 1,
		BAC = 2,
		BCA = 3,
		CAB = 4,
		CBA = 5,
	}

	private sDialogChildArg ChildArg; //Field offset: 0x114
	private DialogLayer m_Layer; //Field offset: 0x118
	private Transform m_IconParent; //Field offset: 0x11C
	private List<UIWrapperButton> m_buttonList; //Field offset: 0x120
	private GenericItemIconPanel m_IconDisp; //Field offset: 0x124
	private PanelInfo m_IconData; //Field offset: 0x128

	public DialogChildObject() { }

	[CompilerGenerated]
	private RawImageEx <SetupEpisodeReleaseWindow>b__9_0(string name) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[IteratorStateMachine(typeof(<FadeAlpha>d__18))]
	private IEnumerator FadeAlpha(RawImageEx image) { }

	public Transform GetIconParent() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[IteratorStateMachine(typeof(<LoadCharacterThumbnailImage>d__17))]
	private IEnumerator LoadCharacterThumbnailImage(DialogChildParameter param, List<RawImageEx> images) { }

	[IteratorStateMachine(typeof(<LoadImage>d__16))]
	private IEnumerator LoadImage(string imagePath, RawImage image1) { }

	[IteratorStateMachine(typeof(<LoadItemImage>d__15))]
	private IEnumerator LoadItemImage(DialogChildParameter param) { }

	private void SetDisableCharacterObjects(List<String> use) { }

	public void SetIconParam() { }

	private void SetupEpisodeReleaseWindow(DialogChildParameter param) { }

	protected virtual void UpdateDispMain() { }

}

