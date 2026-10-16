namespace System.Xml;

internal class ReadContentAsBinaryHelper
{
	private enum State
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2,
	}

	private XmlReader reader; //Field offset: 0x8
	private State state; //Field offset: 0xC
	private int valueOffset; //Field offset: 0x10
	private bool isEnd; //Field offset: 0x14
	private bool canReadValueChunk; //Field offset: 0x15
	private Char[] valueChunk; //Field offset: 0x18
	private int valueChunkLength; //Field offset: 0x1C
	private IncrementalReadDecoder decoder; //Field offset: 0x20
	private Base64Decoder base64Decoder; //Field offset: 0x24
	private BinHexDecoder binHexDecoder; //Field offset: 0x28

	internal ReadContentAsBinaryHelper(XmlReader reader) { }

	internal static ReadContentAsBinaryHelper CreateOrReset(ReadContentAsBinaryHelper helper, XmlReader reader) { }

	internal void Finish() { }

	private bool Init() { }

	private void InitBase64Decoder() { }

	private void InitBinHexDecoder() { }

	private bool InitOnElement() { }

	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	internal int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	private int ReadContentAsBinary(Byte[] buffer, int index, int count) { }

	internal int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	internal int ReadElementContentAsBase64(Byte[] buffer, int index, int count) { }

	private int ReadElementContentAsBinary(Byte[] buffer, int index, int count) { }

	internal int ReadElementContentAsBinHex(Byte[] buffer, int index, int count) { }

	internal void Reset() { }

}

