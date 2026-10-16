namespace GuardProperty;

public struct GuardLongArrayEnumerator : IEnumerator<Int64>, IEnumerator, IDisposable
{
	private GuardLongArray array; //Field offset: 0x0
	private int index; //Field offset: 0x4

	public override long Current
	{
		 get { } //Length: 33
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 59
	}

	public GuardLongArrayEnumerator(GuardLongArray array) { }

	public override void Dispose() { }

	public override long get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

