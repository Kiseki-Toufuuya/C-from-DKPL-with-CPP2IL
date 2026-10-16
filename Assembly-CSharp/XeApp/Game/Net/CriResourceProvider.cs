namespace XeApp.Game.Net;

public class CriResourceProvider : IFileProvider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string cuesheetName; //Field offset: 0x8

		public <>c__DisplayClass8_0() { }

		internal bool <IsEmbeddedResource>b__0(string _) { }

	}

	[CompilerGenerated]
	private sealed class <Co_LoadFromRawDir>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadContext context; //Field offset: 0x10
		public CriResourceProvider <>4__this; //Field offset: 0x14
		public Action<LoadContext> onError; //Field offset: 0x18
		public Action<LoadContext> onSuccess; //Field offset: 0x1C
		private CriAtomCueSheet <cs>5__2; //Field offset: 0x20

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
		public <Co_LoadFromRawDir>d__10(int <>1__state) { }

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
	private sealed class <Co_LoadFromStorage>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadContext context; //Field offset: 0x10
		public CriResourceProvider <>4__this; //Field offset: 0x14
		public Action<LoadContext> onError; //Field offset: 0x18
		public Action<LoadContext> onSuccess; //Field offset: 0x1C
		private string <cuesheetName>5__2; //Field offset: 0x20
		private AssetPathEntry <acbEntry>5__3; //Field offset: 0x24
		private AssetPathEntry <awbEntry>5__4; //Field offset: 0x28
		private CriAtomCueSheet <cs>5__5; //Field offset: 0x2C

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
		public <Co_LoadFromStorage>d__14(int <>1__state) { }

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
	private sealed class <Co_LoadFromStreamingAsset>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadContext context; //Field offset: 0x10
		public CriResourceProvider <>4__this; //Field offset: 0x14
		public Action<LoadContext> onError; //Field offset: 0x18
		public Action<LoadContext> onSuccess; //Field offset: 0x1C
		private CriAtomCueSheet <cs>5__2; //Field offset: 0x20

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
		public <Co_LoadFromStreamingAsset>d__11(int <>1__state) { }

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
	private static CriResourceProvider <Instance>k__BackingField; //Field offset: 0x0
	private static readonly List<String> EmbbededCuesheets; //Field offset: 0x4

	public private static CriResourceProvider Instance
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public static bool IsLoadFromRawData
	{
		 get { } //Length: 3
	}

	private static CriResourceProvider() { }

	public CriResourceProvider() { }

	[IteratorStateMachine(typeof(<Co_LoadFromRawDir>d__10))]
	private IEnumerator Co_LoadFromRawDir(LoadContext context, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[IteratorStateMachine(typeof(<Co_LoadFromStorage>d__14))]
	private IEnumerator Co_LoadFromStorage(LoadContext context, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[IteratorStateMachine(typeof(<Co_LoadFromStreamingAsset>d__11))]
	private IEnumerator Co_LoadFromStreamingAsset(LoadContext context, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[CompilerGenerated]
	public static CriResourceProvider get_Instance() { }

	public static bool get_IsLoadFromRawData() { }

	private string GetSubfolder(string cuesheetName) { }

	public bool IsEmbeddedResource(string cuesheetName) { }

	private bool IsHaveAwb(string cuesheetName) { }

	public override LoadContext LoadRequest(string cuesheetName, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[CompilerGenerated]
	private static void set_Instance(CriResourceProvider value) { }

}

