namespace CriWare;

[AddComponentMenu("CRIWARE/CRI Atom Source")]
public class CriAtomSource : CriAtomSourceBase
{
	[CompilerGenerated]
	private sealed class <PlayAsync>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CriAtomSource <>4__this; //Field offset: 0x10
		public string cueName; //Field offset: 0x14
		private CriAtomExAcb <acb>5__2; //Field offset: 0x18

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
		public <PlayAsync>d__11(int <>1__state) { }

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

	[SerializeField]
	private string _cueName; //Field offset: 0x70
	[SerializeField]
	private string _cueSheet; //Field offset: 0x74

	public string cueName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string cueSheet
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CriAtomSource() { }

	public string get_cueName() { }

	public string get_cueSheet() { }

	protected virtual CriAtomExAcb GetAcb() { }

	public virtual CriAtomExPlayback Play() { }

	[IteratorStateMachine(typeof(<PlayAsync>d__11))]
	private IEnumerator PlayAsync(string cueName) { }

	protected virtual void PlayOnStart() { }

	public void set_cueName(string value) { }

	public void set_cueSheet(string value) { }

}

