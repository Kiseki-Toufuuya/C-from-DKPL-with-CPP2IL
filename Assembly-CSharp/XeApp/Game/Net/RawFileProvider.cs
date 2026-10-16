namespace XeApp.Game.Net;

public class RawFileProvider : IFileProvider
{
	[CompilerGenerated]
	private sealed class <Co_LoadFromStorage>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LoadContext context; //Field offset: 0x10
		public Action<LoadContext> onError; //Field offset: 0x14
		public Action<LoadContext> onSuccess; //Field offset: 0x18
		private AssetPathEntry <entry>5__2; //Field offset: 0x1C
		private string <localPath>5__3; //Field offset: 0x20
		private SemaphoJob <sema>5__4; //Field offset: 0x24
		private CriFsLoadFileRequest <req>5__5; //Field offset: 0x28

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
		public <Co_LoadFromStorage>d__13(int <>1__state) { }

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
		public Action<LoadContext> onError; //Field offset: 0x14
		public RawFileProvider <>4__this; //Field offset: 0x18
		public Action<LoadContext> onSuccess; //Field offset: 0x1C
		private CriFsLoadFileRequest <req>5__2; //Field offset: 0x20

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
	private static RawFileProvider <Instance>k__BackingField; //Field offset: 0x0
	private const int defaultDBSalt = 7478; //Field offset: 0x0
	private const int DOWNLOAD_OPTION_XAB_SALT_MASK = 4095; //Field offset: 0x0
	private LightWeightEncryptor defaultDBEncryptor; //Field offset: 0x8

	public private static RawFileProvider Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public static bool IsLoadFromRawData
	{
		 get { } //Length: 3
	}

	public RawFileProvider() { }

	[IteratorStateMachine(typeof(<Co_LoadFromStorage>d__13))]
	private IEnumerator Co_LoadFromStorage(LoadContext context, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[IteratorStateMachine(typeof(<Co_LoadFromStreamingAsset>d__11))]
	private IEnumerator Co_LoadFromStreamingAsset(LoadContext context, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[CompilerGenerated]
	public static RawFileProvider get_Instance() { }

	public static bool get_IsLoadFromRawData() { }

	public bool IsEmbeddedResource(string pathWithoutPlatform) { }

	public override LoadContext LoadRequest(string pathWithoutPlatform, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

	[CompilerGenerated]
	private static void set_Instance(RawFileProvider value) { }

}

