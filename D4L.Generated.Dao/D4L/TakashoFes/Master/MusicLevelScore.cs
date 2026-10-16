namespace D4L.TakashoFes.Master;

public sealed class MusicLevelScore : IFlatbuffersDao<MusicLevelScoreEntry, Int32>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<MusicLevelScoreEntry>, IEnumerable, IEnumerator<MusicLevelScoreEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private MusicLevelScoreEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int32> ids; //Field offset: 0x14
		public IEnumerable<Int32> <>3__ids; //Field offset: 0x18
		public MusicLevelScore <>4__this; //Field offset: 0x1C
		private IEnumerator<Int32> <>7__wrap1; //Field offset: 0x20

		private override MusicLevelScoreEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.MusicLevelScoreEntry>.Current
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
		public <Get>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<MusicLevelScoreEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.MusicLevelScoreEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override MusicLevelScoreEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.MusicLevelScoreEntry>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private object __internal_table_lock; //Field offset: 0x8
	private Dictionary<Int32, Int32> identityDict; //Field offset: 0xC
	private MusicLevelScoreRaw master; //Field offset: 0x10
	private MusicLevelScoreEntry[] entries; //Field offset: 0x18

	public override MusicLevelScoreEntry[] Entries
	{
		 get { } //Length: 456
	}

	public MusicLevelScore(Byte[] buffer) { }

	private Dictionary<Int32, Int32> CreateIdentityDictionary(MusicLevelScoreRaw source) { }

	public override MusicLevelScoreEntry Get(int id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<MusicLevelScoreEntry> Get(IEnumerable<Int32> ids) { }

	public override MusicLevelScoreEntry[] get_Entries() { }

	public override IEnumerable<MusicLevelScoreEntry> GetAll() { }

	private Dictionary<Int32, Int32> IdentityDict() { }

}

