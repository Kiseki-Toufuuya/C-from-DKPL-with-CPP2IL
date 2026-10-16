namespace D4L.TakashoFes.Master;

public sealed class ImageHelp : IFlatbuffersDao<ImageHelpEntry, Int64>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<ImageHelpEntry>, IEnumerable, IEnumerator<ImageHelpEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private ImageHelpEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int64> ids; //Field offset: 0x14
		public IEnumerable<Int64> <>3__ids; //Field offset: 0x18
		public ImageHelp <>4__this; //Field offset: 0x1C
		private IEnumerator<Int64> <>7__wrap1; //Field offset: 0x20

		private override ImageHelpEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.ImageHelpEntry>.Current
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
		private override IEnumerator<ImageHelpEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.ImageHelpEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override ImageHelpEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.ImageHelpEntry>.get_Current() { }

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
	private ImageHelpRaw master; //Field offset: 0x10
	private ImageHelpEntry[] entries; //Field offset: 0x18

	public override ImageHelpEntry[] Entries
	{
		 get { } //Length: 456
	}

	public ImageHelp(Byte[] buffer) { }

	private Dictionary<Int64, Int32> CreateIdentityDictionary(ImageHelpRaw source) { }

	public override ImageHelpEntry Get(long id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<ImageHelpEntry> Get(IEnumerable<Int64> ids) { }

	public override ImageHelpEntry[] get_Entries() { }

	public override IEnumerable<ImageHelpEntry> GetAll() { }

	private Dictionary<Int64, Int32> IdentityDict() { }

}

