namespace D4L.TakashoFes.Master;

public sealed class HeroineSkill : IFlatbuffersDao<HeroineSkillEntry, GuardInt>
{
	[CompilerGenerated]
	private sealed class <Get>d__12 : IEnumerable<HeroineSkillEntry>, IEnumerable, IEnumerator<HeroineSkillEntry>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private HeroineSkillEntry <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<GuardInt> ids; //Field offset: 0x14
		public IEnumerable<GuardInt> <>3__ids; //Field offset: 0x18
		public HeroineSkill <>4__this; //Field offset: 0x1C
		private IEnumerator<GuardInt> <>7__wrap1; //Field offset: 0x20

		private override HeroineSkillEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.HeroineSkillEntry>.Current
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
		private override IEnumerator<HeroineSkillEntry> System.Collections.Generic.IEnumerable<D4L.TakashoFes.Master.HeroineSkillEntry>.GetEnumerator() { }

		[DebuggerHidden]
		private override HeroineSkillEntry System.Collections.Generic.IEnumerator<D4L.TakashoFes.Master.HeroineSkillEntry>.get_Current() { }

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
	private HeroineSkillRaw master; //Field offset: 0x10
	private HeroineSkillEntry[] entries; //Field offset: 0x18

	public override HeroineSkillEntry[] Entries
	{
		 get { } //Length: 456
	}

	public HeroineSkill(Byte[] buffer) { }

	private Dictionary<GuardInt, Int32> CreateIdentityDictionary(HeroineSkillRaw source) { }

	public override HeroineSkillEntry Get(GuardInt id) { }

	[IteratorStateMachine(typeof(<Get>d__12))]
	public override IEnumerable<HeroineSkillEntry> Get(IEnumerable<GuardInt> ids) { }

	public override HeroineSkillEntry[] get_Entries() { }

	public override IEnumerable<HeroineSkillEntry> GetAll() { }

	private Dictionary<GuardInt, Int32> IdentityDict() { }

}

