namespace System.Security.Cryptography;

internal class AesTransform : SymmetricTransform
{
	private static readonly UInt32[] Rcon; //Field offset: 0x0
	private static readonly Byte[] SBox; //Field offset: 0x4
	private static readonly Byte[] iSBox; //Field offset: 0x8
	private static readonly UInt32[] T0; //Field offset: 0xC
	private static readonly UInt32[] T1; //Field offset: 0x10
	private static readonly UInt32[] T2; //Field offset: 0x14
	private static readonly UInt32[] T3; //Field offset: 0x18
	private static readonly UInt32[] iT0; //Field offset: 0x1C
	private static readonly UInt32[] iT1; //Field offset: 0x20
	private static readonly UInt32[] iT2; //Field offset: 0x24
	private static readonly UInt32[] iT3; //Field offset: 0x28
	private UInt32[] expandedKey; //Field offset: 0x34
	private int Nk; //Field offset: 0x38
	private int Nr; //Field offset: 0x3C

	private static AesTransform() { }

	public AesTransform(Aes algo, bool encryption, Byte[] key, Byte[] iv) { }

	private void Decrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	protected virtual void ECB(Byte[] input, Byte[] output) { }

	private void Encrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	private uint SubByte(uint a) { }

}

