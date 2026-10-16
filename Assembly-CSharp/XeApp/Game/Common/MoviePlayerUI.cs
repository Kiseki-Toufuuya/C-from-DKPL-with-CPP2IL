namespace XeApp.Game.Common;

[RequireComponent(typeof(CriManaMovieControllerForUI))]
public class MoviePlayerUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Co_Prepare>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MoviePlayerUI <>4__this; //Field offset: 0x10

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
		public <Co_Prepare>d__8(int <>1__state) { }

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
	private CriManaMovieControllerForUI manaMovieController; //Field offset: 0x10
	[CompilerGenerated]
	private GuardString <RawMoviePath>k__BackingField; //Field offset: 0x14

	public MovieInfo MovieInfo
	{
		 get { } //Length: 41
	}

	public GuardString RawMoviePath
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public MoviePlayerUI() { }

	[IteratorStateMachine(typeof(<Co_Prepare>d__8))]
	private IEnumerator Co_Prepare() { }

	public MovieInfo get_MovieInfo() { }

	[CompilerGenerated]
	public GuardString get_RawMoviePath() { }

	public bool IsPlayEnd() { }

	public bool IsReady() { }

	public void Play() { }

	public void Prepare() { }

	[CompilerGenerated]
	public void set_RawMoviePath(GuardString value) { }

}

