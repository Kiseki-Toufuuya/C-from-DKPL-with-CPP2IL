namespace XeSys;

public class CRC32 : HashAlgorithm
{
	private const uint CRC_MASK = 4294967295; //Field offset: 0x0
	private static readonly UInt32[] m_table; //Field offset: 0x0
	[CompilerGenerated]
	private uint <crcValue>k__BackingField; //Field offset: 0x18

	public private uint crcValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static CRC32() { }

	public CRC32() { }

	[CompilerGenerated]
	public uint get_crcValue() { }

	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	public uint MakeHash(Byte[] bytes, int start, int length) { }

	[CompilerGenerated]
	private void set_crcValue(uint value) { }

}

