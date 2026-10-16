namespace XeApp.Core;

public class ShaderAssetBundleLoadOperation : UnionAssetBundleLoadOperation
{
	[CompilerGenerated]
	private sealed class <PreLoadShader>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public String[] assetName; //Field offset: 0x10
		public ShaderAssetBundleLoadOperation <>4__this; //Field offset: 0x14
		private int <count>5__2; //Field offset: 0x18
		private int <loadCount>5__3; //Field offset: 0x1C
		private AssetBundleRequest <op>5__4; //Field offset: 0x20

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
		public <PreLoadShader>d__1(int <>1__state) { }

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


	public ShaderAssetBundleLoadOperation(string bundleName) { }

	[IteratorStateMachine(typeof(<PreLoadShader>d__1))]
	public override IEnumerator PreLoadShader(String[] assetName) { }

}

