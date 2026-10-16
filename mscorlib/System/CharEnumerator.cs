namespace System;

public sealed class CharEnumerator : IEnumerator, IEnumerator<Char>, IDisposable, ICloneable
{
	private string _str; //Field offset: 0x8
	private int _index; //Field offset: 0xC
	private char _currentElement; //Field offset: 0x10

	public override char Current
	{
		 get { } //Length: 170
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 191
	}

	internal CharEnumerator(string str) { }

	internal CharEnumerator() { }

	public override object Clone() { }

	public override void Dispose() { }

	public override char get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

