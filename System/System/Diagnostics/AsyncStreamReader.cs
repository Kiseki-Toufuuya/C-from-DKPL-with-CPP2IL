namespace System.Diagnostics;

internal class AsyncStreamReader
{
	private Stream stream; //Field offset: 0x8
	private Encoding encoding; //Field offset: 0xC
	private Decoder decoder; //Field offset: 0x10
	private Byte[] byteBuffer; //Field offset: 0x14
	private Char[] charBuffer; //Field offset: 0x18
	private bool cancelOperation; //Field offset: 0x1C
	private ManualResetEvent eofEvent; //Field offset: 0x20
	private object syncObject; //Field offset: 0x24
	private IAsyncResult asyncReadResult; //Field offset: 0x28

	internal void CancelOperation() { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

}

