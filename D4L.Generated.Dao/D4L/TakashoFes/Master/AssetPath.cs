namespace D4L.TakashoFes.Master;

public sealed class AssetPath : IFlatbuffersDao<AssetPathEntry, Int64>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<AssetPathEntry>, IEnumerable, IEnumerator<AssetPathEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private AssetPathEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int64> ids; //Field offset: 0x14
		public IEnumerable<Int64> <>3__ids; //Field offset: 0x18
		public AssetPath <>4__this; //Field offset: 0x1C
		private IEnumerator<Int64> <>7__wrap1; //Field offset: 0x20

		private override AssetPathEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.AssetPathEntry>.Current
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
		private override IEnumerator<AssetPathEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.AssetPathEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override AssetPathEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.AssetPathEntry>.get_Current() { }

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
	private AssetPathRaw master; //Field offset: 0x10
	private AssetPathEntry[] entries; //Field offset: 0x18

	public override AssetPathEntry[] Entries
	{
		 get { } //Length: 456
	}

	public AssetPathRaw Raw
	{
		 get { } //Length: 14
	}

	public AssetPath(Byte[] buffer) { }

	private Dictionary<Int64, Int32> CreateIdentityDictionary(AssetPathRaw source) { }

	public override AssetPathEntry Get(long id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<AssetPathEntry> Get(IEnumerable<Int64> ids) { }

	public override AssetPathEntry[] get_Entries() { }

	public AssetPathRaw get_Raw() { }

	public override IEnumerable<AssetPathEntry> GetAll() { }

	private Dictionary<Int64, Int32> IdentityDict() { }

}

