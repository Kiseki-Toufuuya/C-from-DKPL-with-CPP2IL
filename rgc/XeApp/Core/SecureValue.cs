namespace XeApp.Core;

public class SecureValue
{
	private static object lockObj; //Field offset: 0x0
	private static XorShift xorShift; //Field offset: 0x4
	private static Byte[] swizzle; //Field offset: 0x8

	private static SecureValue() { }

	public SecureValue() { }

	public static SecureInt Int(int v) { }

	public static SecureLong Long(long v) { }

	public static SecureString String(string v) { }

	public static SecureUInt UInt(uint v) { }

	public static SecureULong ULong(uint v) { }

	public static int xor() { }

}

