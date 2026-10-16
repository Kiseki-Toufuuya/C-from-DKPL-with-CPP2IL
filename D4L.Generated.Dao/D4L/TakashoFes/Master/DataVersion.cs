namespace D4L.TakashoFes.Master;

public sealed class DataVersion : IFlatbuffersDao<DataVersionEntry, Int64>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<DataVersionEntry>, IEnumerable, IEnumerator<DataVersionEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private DataVersionEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int64> ids; //Field offset: 0x14
		public IEnumerable<Int64> <>3__ids; //Field offset: 0x18
		public DataVersion <>4__this; //Field offset: 0x1C
		private IEnumerator<Int64> <>7__wrap1; //Field offset: 0x20

		private override DataVersionEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.DataVersionEntry>.Current
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
		private override IEnumerator<DataVersionEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.DataVersionEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override DataVersionEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.DataVersionEntry>.get_Current() { }

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
	private Dictionary<Int64, Int32> identityDict; //Field offset: 0xC
	private DataVersionRaw master; //Field offset: 0x10
	private DataVersionEntry[] entries; //Field offset: 0x18

	public override DataVersionEntry[] Entries
	{
		 get { } //Length: 456
	}

	public DataVersion(Byte[] buffer) { }

	private Dictionary<Int64, Int32> CreateIdentityDictionary(DataVersionRaw source) { }

	public override DataVersionEntry Get(long id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<DataVersionEntry> Get(IEnumerable<Int64> ids) { }

	public override DataVersionEntry[] get_Entries() { }

	public override IEnumerable<DataVersionEntry> GetAll() { }

	private Dictionary<Int64, Int32> IdentityDict() { }

}

