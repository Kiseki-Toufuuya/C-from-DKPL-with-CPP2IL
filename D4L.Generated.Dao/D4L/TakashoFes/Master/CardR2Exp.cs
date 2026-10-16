namespace D4L.TakashoFes.Master;

public sealed class CardR2Exp : IFlatbuffersDao<CardR2ExpEntry, GuardInt>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<CardR2ExpEntry>, IEnumerable, IEnumerator<CardR2ExpEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private CardR2ExpEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<GuardInt> ids; //Field offset: 0x14
		public IEnumerable<GuardInt> <>3__ids; //Field offset: 0x18
		public CardR2Exp <>4__this; //Field offset: 0x1C
		private IEnumerator<GuardInt> <>7__wrap1; //Field offset: 0x20

		private override CardR2ExpEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.CardR2ExpEntry>.Current
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
		private override IEnumerator<CardR2ExpEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.CardR2ExpEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override CardR2ExpEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.CardR2ExpEntry>.get_Current() { }

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
	private CardR2ExpRaw master; //Field offset: 0x10
	private CardR2ExpEntry[] entries; //Field offset: 0x18

	public override CardR2ExpEntry[] Entries
	{
		 get { } //Length: 456
	}

	public CardR2Exp(Byte[] buffer) { }

	private Dictionary<GuardInt, Int32> CreateIdentityDictionary(CardR2ExpRaw source) { }

	public override CardR2ExpEntry Get(GuardInt id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<CardR2ExpEntry> Get(IEnumerable<GuardInt> ids) { }

	public override CardR2ExpEntry[] get_Entries() { }

	public override IEnumerable<CardR2ExpEntry> GetAll() { }

	private Dictionary<GuardInt, Int32> IdentityDict() { }

}

