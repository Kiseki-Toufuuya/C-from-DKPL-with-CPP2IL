namespace Heqet;

public class CriSeSource
{
	[CompilerGenerated]
	private sealed class <WaitInstall>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string cueSheetName; //Field offset: 0x10
		public CriSeSource <>4__this; //Field offset: 0x14

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
		public <WaitInstall>d__15(int <>1__state) { }

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

	private CriAtomSource CriSource; //Field offset: 0x8
	private CueSheetID CueSheetID; //Field offset: 0xC
	private bool seEnable; //Field offset: 0x10
	private GameObject Object; //Field offset: 0x14
	public bool IsPrepared; //Field offset: 0x18
	private Dictionary<Int32, CriAtomExPlayback> managedList; //Field offset: 0x1C

	public GameObject gameobject
	{
		 get { } //Length: 11
	}

	public bool SeEnalbe
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Status Status
	{
		 get { } //Length: 34
	}

	public CriSeSource(CueSheetID cueSheetID) { }

	public GameObject get_gameobject() { }

	public bool get_SeEnalbe() { }

	public Status get_Status() { }

	public CriAtomExPlayback PlayStart(int cueId, bool managedLoop = false) { }

	public void Prepare() { }

	public void set_SeEnalbe(bool value) { }

	public void SetVolume(float volume) { }

	public void Shutdown() { }

	public void StopAll() { }

	public void StopCueId(int cueId) { }

	[IteratorStateMachine(typeof(<WaitInstall>d__15))]
	private IEnumerator WaitInstall(string cueSheetName) { }

}

