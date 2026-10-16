namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public abstract class FormatItem
{
	private struct PartialCharEnumerator : IEnumerable<Char>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__4 : IEnumerator<Char>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private char <>2__current; //Field offset: 0xC
			public PartialCharEnumerator <>4__this; //Field offset: 0x10
			private int <i>5__2; //Field offset: 0x1C

			private override char System.Collections.Generic.IEnumerator<System.Char>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 12
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 33
			}

			[DebuggerHidden]
			public <GetEnumerator>d__4(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override char System.Collections.Generic.IEnumerator<System.Char>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private string m_BaseString; //Field offset: 0x0
		private int m_From; //Field offset: 0x4
		private int m_To; //Field offset: 0x8

		public PartialCharEnumerator(string s, int from, int to) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__4))]
		public override IEnumerator<Char> GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public string baseString; //Field offset: 0x8
	public int endIndex; //Field offset: 0xC
	protected SmartSettings SmartSettings; //Field offset: 0x10
	public int startIndex; //Field offset: 0x14
	protected string m_RawText; //Field offset: 0x18
	[CompilerGenerated]
	private FormatItem <Parent>k__BackingField; //Field offset: 0x1C

	public private FormatItem Parent
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public string RawText
	{
		 get { } //Length: 65
	}

	protected FormatItem() { }

	public override void Clear() { }

	[CompilerGenerated]
	public FormatItem get_Parent() { }

	public string get_RawText() { }

	public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex) { }

	public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex) { }

	public void Init(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex) { }

	[CompilerGenerated]
	private void set_Parent(FormatItem value) { }

	public IEnumerable<Char> ToEnumerable() { }

	public virtual string ToString() { }

}

