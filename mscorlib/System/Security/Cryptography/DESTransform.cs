namespace System.Security.Cryptography;

internal class DESTransform : SymmetricTransform
{
	internal static readonly int KEY_BIT_SIZE; //Field offset: 0x0
	internal static readonly int KEY_BYTE_SIZE; //Field offset: 0x4
	internal static readonly int BLOCK_BIT_SIZE; //Field offset: 0x8
	internal static readonly int BLOCK_BYTE_SIZE; //Field offset: 0xC
	private static readonly UInt32[] spBoxes; //Field offset: 0x10
	private static readonly Byte[] PC1; //Field offset: 0x14
	private static readonly Byte[] leftRotTotal; //Field offset: 0x18
	private static readonly Byte[] PC2; //Field offset: 0x1C
	internal static readonly UInt32[] ipTab; //Field offset: 0x20
	internal static readonly UInt32[] fpTab; //Field offset: 0x24
	private Byte[] keySchedule; //Field offset: 0x34
	private Byte[] byteBuff; //Field offset: 0x38
	private UInt32[] dwordBuff; //Field offset: 0x3C

	private static DESTransform() { }

	internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] key, Byte[] iv) { }

	private static void BSwap(Byte[] byteBuff) { }

	private uint CipherFunct(uint r, int n) { }

	protected virtual void ECB(Byte[] input, Byte[] output) { }

	internal static Byte[] GetStrongKey() { }

	internal static void Permutation(Byte[] input, Byte[] output, UInt32[] permTab, bool preSwap) { }

	public void ProcessBlock(Byte[] input, Byte[] output) { }

	internal void SetKey(Byte[] key) { }

}

