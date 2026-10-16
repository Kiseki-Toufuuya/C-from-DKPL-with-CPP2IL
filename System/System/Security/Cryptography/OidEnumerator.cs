namespace System.Security.Cryptography;

public sealed class OidEnumerator : IEnumerator
{
	private readonly OidCollection _oids; //Field offset: 0x8
	private int _current; //Field offset: 0xC

	public Oid Current
	{
		 get { } //Length: 79
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 79
	}

	internal OidEnumerator(OidCollection oids) { }

	public Oid get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

