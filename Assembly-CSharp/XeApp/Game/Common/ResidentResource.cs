namespace XeApp.Game.Common;

public class ResidentResource
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AssetBundleLoadAssetOperation> <>9__11_0; //Field offset: 0x4
		public static Action<AssetBundleLoadAssetOperation> <>9__11_1; //Field offset: 0x8
		public static Action<AssetBundleLoadAssetOperation> <>9__11_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal void <Co_Load>b__11_0(AssetBundleLoadAssetOperation operation) { }

		internal void <Co_Load>b__11_1(AssetBundleLoadAssetOperation operation) { }

		internal void <Co_Load>b__11_2(AssetBundleLoadAssetOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <Co_Load>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ResidentResource <>4__this; //Field offset: 0x10
		private ShaderAssetBundleLoadOperation <shader>5__2; //Field offset: 0x14
		private ShaderAssetBundleLoadOperation <material>5__3; //Field offset: 0x18
		private UnionAssetBundleLoadOperation <req>5__4; //Field offset: 0x1C

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
		public <Co_Load>d__11(int <>1__state) { }

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
	private static ResidentResource <Instance>k__BackingField; //Field offset: 0x0
	private List<String> loadBundles; //Field offset: 0x8
	[CompilerGenerated]
	private bool <IsReady>k__BackingField; //Field offset: 0xC

	public static ResidentResource Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public private bool IsReady
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ResidentResource() { }

	[IteratorStateMachine(typeof(<Co_Load>d__11))]
	private IEnumerator Co_Load() { }

	public void Create() { }

	[CompilerGenerated]
	public static ResidentResource get_Instance() { }

	[CompilerGenerated]
	public bool get_IsReady() { }

	public void Load() { }

	[CompilerGenerated]
	public static void set_Instance(ResidentResource value) { }

	[CompilerGenerated]
	private void set_IsReady(bool value) { }

	public void Unload() { }

}

