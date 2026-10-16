namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class Base64Encoder
{
	private readonly Char[] _charsLine; //Field offset: 0x8
	private readonly TextWriter _writer; //Field offset: 0xC
	[Nullable(2)]
	private Byte[] _leftOverBytes; //Field offset: 0x10
	private int _leftOverBytesCount; //Field offset: 0x14

	public Base64Encoder(TextWriter writer) { }

	public void Encode(Byte[] buffer, int index, int count) { }

	public void Flush() { }

	private bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	private void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	private void WriteChars(Char[] chars, int index, int count) { }

}

