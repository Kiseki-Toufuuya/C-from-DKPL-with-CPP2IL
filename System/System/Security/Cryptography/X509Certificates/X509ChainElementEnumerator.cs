namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainElementEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x8

	public X509ChainElement Current
	{
		 get { } //Length: 137
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 66
	}

	internal X509ChainElementEnumerator(IEnumerable enumerable) { }

	public X509ChainElement get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

