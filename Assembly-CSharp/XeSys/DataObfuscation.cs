namespace XeSys;

public class DataObfuscation
{
	private const ulong TAG_EZOBFUSCATION = 8315441855479508568; //Field offset: 0x0
	private const int TAG_SIZE = 8; //Field offset: 0x0

	public DataObfuscation() { }

	public static void EasyDecrypt(Byte[] data, int dataLength = 0) { }

	public static Byte[] EasyEncrypt(string hashname, Byte[] data, int length = -1) { }

	public static bool IsObfuscatedData(Byte[] data, int length) { }

}

