namespace Mono.Security.Cryptography;

public class MD2Managed : MD2
{
	private static readonly Byte[] PI_SUBST; //Field offset: 0x0
	private Byte[] state; //Field offset: 0x18
	private Byte[] checksum; //Field offset: 0x1C
	private Byte[] buffer; //Field offset: 0x20
	private int count; //Field offset: 0x24
	private Byte[] x; //Field offset: 0x28

	private static MD2Managed() { }

	public MD2Managed() { }

	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	private Byte[] Padding(int nLength) { }

}

