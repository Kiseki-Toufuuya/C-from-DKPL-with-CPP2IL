namespace GuardProperty;

public struct GuardBoolArrayEnumerator : IEnumerator<Boolean>, IEnumerator, IDisposable
{
	private GuardBoolArray array; //Field offset: 0x0
	private int index; //Field offset: 0x4

	public override bool Current
	{
		 get { } //Length: 350
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 39
	}

	public GuardBoolArrayEnumerator(GuardBoolArray array) { }

	public override void Dispose() { }

	public override bool get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

