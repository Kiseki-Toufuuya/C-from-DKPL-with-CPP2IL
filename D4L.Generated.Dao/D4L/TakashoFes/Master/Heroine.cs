namespace D4L.TakashoFes.Master;

public sealed class Heroine : IFlatbuffersDao<HeroineEntry, GuardInt>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<HeroineEntry>, IEnumerable, IEnumerator<HeroineEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private HeroineEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<GuardInt> ids; //Field offset: 0x14
		public IEnumerable<GuardInt> <>3__ids; //Field offset: 0x18
		public Heroine <>4__this; //Field offset: 0x1C
		private IEnumerator<GuardInt> <>7__wrap1; //Field offset: 0x20

		private override HeroineEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.HeroineEntry>.Current
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
		private override IEnumerator<HeroineEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.HeroineEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override HeroineEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.HeroineEntry>.get_Current() { }

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
	private HeroineRaw master; //Field offset: 0x10
	private HeroineEntry[] entries; //Field offset: 0x18

	public override HeroineEntry[] Entries
	{
		 get { } //Length: 456
	}

	public Heroine(Byte[] buffer) { }

	private Dictionary<GuardInt, Int32> CreateIdentityDictionary(HeroineRaw source) { }

	public override HeroineEntry Get(GuardInt id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<HeroineEntry> Get(IEnumerable<GuardInt> ids) { }

	public override HeroineEntry[] get_Entries() { }

	public override IEnumerable<HeroineEntry> GetAll() { }

	private Dictionary<GuardInt, Int32> IdentityDict() { }

}

