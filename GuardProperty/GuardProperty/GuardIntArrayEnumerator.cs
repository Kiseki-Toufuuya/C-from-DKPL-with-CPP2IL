namespace GuardProperty;

public struct GuardIntArrayEnumerator : IEnumerator<Int32>, IEnumerator, IDisposable
{
	private GuardIntArray array; //Field offset: 0x0
	private int index; //Field offset: 0x4

	public override int Current
	{
		 get { } //Length: 33
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 51
	}

	public GuardIntArrayEnumerator(GuardIntArray array) { }

	public override void Dispose() { }

	public override int get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

