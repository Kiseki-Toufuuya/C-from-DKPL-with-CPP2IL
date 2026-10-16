namespace System.Runtime.Serialization;

internal class BitFlagsGenerator
{
	private int bitCount; //Field offset: 0x8
	private Byte[] locals; //Field offset: 0xC

	public BitFlagsGenerator(int bitCount) { }

	public int GetBitCount() { }

	private static byte GetBitValue(int bitIndex) { }

	private static int GetByteIndex(int bitIndex) { }

	public byte GetLocal(int i) { }

	public int GetLocalCount() { }

	public static bool IsBitSet(Byte[] bytes, int bitIndex) { }

	public bool Load(int bitIndex) { }

	public Byte[] LoadArray() { }

	public static void SetBit(Byte[] bytes, int bitIndex) { }

	public void Store(int bitIndex, bool value) { }

}

