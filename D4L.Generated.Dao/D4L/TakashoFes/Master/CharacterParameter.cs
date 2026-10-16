namespace D4L.TakashoFes.Master;

public sealed class CharacterParameter : IFlatbuffersDao<CharacterParameterEntry, GuardInt>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<CharacterParameterEntry>, IEnumerable, IEnumerator<CharacterParameterEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private CharacterParameterEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<GuardInt> ids; //Field offset: 0x14
		public IEnumerable<GuardInt> <>3__ids; //Field offset: 0x18
		public CharacterParameter <>4__this; //Field offset: 0x1C
		private IEnumerator<GuardInt> <>7__wrap1; //Field offset: 0x20

		private override CharacterParameterEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.CharacterParameterEntry>.Current
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
		private override IEnumerator<CharacterParameterEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.CharacterParameterEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override CharacterParameterEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.CharacterParameterEntry>.get_Current() { }

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
	private CharacterParameterRaw master; //Field offset: 0x10
	private CharacterParameterEntry[] entries; //Field offset: 0x18

	public override CharacterParameterEntry[] Entries
	{
		 get { } //Length: 456
	}

	public CharacterParameter(Byte[] buffer) { }

	private Dictionary<GuardInt, Int32> CreateIdentityDictionary(CharacterParameterRaw source) { }

	public override CharacterParameterEntry Get(GuardInt id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<CharacterParameterEntry> Get(IEnumerable<GuardInt> ids) { }

	public override CharacterParameterEntry[] get_Entries() { }

	public override IEnumerable<CharacterParameterEntry> GetAll() { }

	private Dictionary<GuardInt, Int32> IdentityDict() { }

}

