namespace Mono.Globalization.Unicode;

internal class SortKeyBuffer
{
	private Byte[] l1b; //Field offset: 0x8
	private Byte[] l2b; //Field offset: 0xC
	private Byte[] l3b; //Field offset: 0x10
	private Byte[] l4sb; //Field offset: 0x14
	private Byte[] l4tb; //Field offset: 0x18
	private Byte[] l4kb; //Field offset: 0x1C
	private Byte[] l4wb; //Field offset: 0x20
	private Byte[] l5b; //Field offset: 0x24
	private string source; //Field offset: 0x28
	private int l1; //Field offset: 0x2C
	private int l2; //Field offset: 0x30
	private int l3; //Field offset: 0x34
	private int l4s; //Field offset: 0x38
	private int l4t; //Field offset: 0x3C
	private int l4k; //Field offset: 0x40
	private int l4w; //Field offset: 0x44
	private int l5; //Field offset: 0x48
	private int lcid; //Field offset: 0x4C
	private CompareOptions options; //Field offset: 0x50
	private bool processLevel2; //Field offset: 0x54
	private bool frenchSort; //Field offset: 0x55
	private bool frenchSorted; //Field offset: 0x56

	public SortKeyBuffer(int lcid) { }

	private void AppendBufferPrimitive(byte value, ref Byte[] buf, ref int bidx) { }

	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	private void AppendLevel5(byte category, byte lv1) { }

	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	private int GetOptimizedLength(Byte[] data, int len, byte defaultValue) { }

	public SortKey GetResult() { }

	public SortKey GetResultAndReset() { }

	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	public void Reset() { }

}

