namespace D4L.TakashoFes.Master;

public sealed class MessageMap : IFlatbuffersDao<MessageMapEntry, Int64>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<MessageMapEntry>, IEnumerable, IEnumerator<MessageMapEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private MessageMapEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int64> ids; //Field offset: 0x14
		public IEnumerable<Int64> <>3__ids; //Field offset: 0x18
		public MessageMap <>4__this; //Field offset: 0x1C
		private IEnumerator<Int64> <>7__wrap1; //Field offset: 0x20

		private override MessageMapEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.MessageMapEntry>.Current
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
		private override IEnumerator<MessageMapEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.MessageMapEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override MessageMapEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.MessageMapEntry>.get_Current() { }

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
	private MessageMapRaw master; //Field offset: 0x10
	private MessageMapEntry[] entries; //Field offset: 0x18

	public override MessageMapEntry[] Entries
	{
		 get { } //Length: 456
	}

	public MessageMapRaw Raw
	{
		 get { } //Length: 14
	}

	public MessageMap(Byte[] buffer) { }

	private Dictionary<Int64, Int32> CreateIdentityDictionary(MessageMapRaw source) { }

	public override MessageMapEntry Get(long id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<MessageMapEntry> Get(IEnumerable<Int64> ids) { }

	public override MessageMapEntry[] get_Entries() { }

	public MessageMapRaw get_Raw() { }

	public override IEnumerable<MessageMapEntry> GetAll() { }

	private Dictionary<Int64, Int32> IdentityDict() { }

}

