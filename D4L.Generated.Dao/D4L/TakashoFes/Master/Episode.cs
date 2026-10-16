namespace D4L.TakashoFes.Master;

public sealed class Episode : IFlatbuffersDao<EpisodeEntry, GuardInt>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<EpisodeEntry>, IEnumerable, IEnumerator<EpisodeEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private EpisodeEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<GuardInt> ids; //Field offset: 0x14
		public IEnumerable<GuardInt> <>3__ids; //Field offset: 0x18
		public Episode <>4__this; //Field offset: 0x1C
		private IEnumerator<GuardInt> <>7__wrap1; //Field offset: 0x20

		private override EpisodeEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.EpisodeEntry>.Current
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
		private override IEnumerator<EpisodeEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.EpisodeEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override EpisodeEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.EpisodeEntry>.get_Current() { }

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
	private Dictionary<GuardInt, Int32> identityDict; //Field offset: 0xC
	private EpisodeRaw master; //Field offset: 0x10
	private EpisodeEntry[] entries; //Field offset: 0x18

	public override EpisodeEntry[] Entries
	{
		 get { } //Length: 456
	}

	public Episode(Byte[] buffer) { }

	private Dictionary<GuardInt, Int32> CreateIdentityDictionary(EpisodeRaw source) { }

	public override EpisodeEntry Get(GuardInt id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<EpisodeEntry> Get(IEnumerable<GuardInt> ids) { }

	public override EpisodeEntry[] get_Entries() { }

	public override IEnumerable<EpisodeEntry> GetAll() { }

	private Dictionary<GuardInt, Int32> IdentityDict() { }

}

