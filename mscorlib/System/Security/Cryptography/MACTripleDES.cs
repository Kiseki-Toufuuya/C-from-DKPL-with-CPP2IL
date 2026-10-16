namespace System.Security.Cryptography;

[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm
{
	private const int m_bitsPerByte = 8; //Field offset: 0x0
	private ICryptoTransform m_encryptor; //Field offset: 0x1C
	private CryptoStream _cs; //Field offset: 0x20
	private TailStream _ts; //Field offset: 0x24
	private int m_bytesPerBlock; //Field offset: 0x28
	private TripleDES des; //Field offset: 0x2C

	[ComVisible(False)]
	public PaddingMode Padding
	{
		 get { } //Length: 40
		 set { } //Length: 126
	}

	public MACTripleDES() { }

	public MACTripleDES(Byte[] rgbKey) { }

	public MACTripleDES(string strTripleDES, Byte[] rgbKey) { }

	protected virtual void Dispose(bool disposing) { }

	public PaddingMode get_Padding() { }

	protected virtual void HashCore(Byte[] rgbData, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	public void set_Padding(PaddingMode value) { }

}

