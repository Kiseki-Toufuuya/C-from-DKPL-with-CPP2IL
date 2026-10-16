namespace Mono.Security.Cryptography;

public class MD4Managed : MD4
{
	private UInt32[] state; //Field offset: 0x18
	private Byte[] buffer; //Field offset: 0x1C
	private UInt32[] count; //Field offset: 0x20
	private UInt32[] x; //Field offset: 0x24
	private Byte[] digest; //Field offset: 0x28

	public MD4Managed() { }

	private void Decode(UInt32[] output, Byte[] input, int index) { }

	private void Encode(Byte[] output, UInt32[] input) { }

	private uint F(uint x, uint y, uint z) { }

	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private uint G(uint x, uint y, uint z) { }

	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private uint H(uint x, uint y, uint z) { }

	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	public virtual void Initialize() { }

	private void MD4Transform(UInt32[] state, Byte[] block, int index) { }

	private Byte[] Padding(int nLength) { }

	private uint ROL(uint x, byte n) { }

}

