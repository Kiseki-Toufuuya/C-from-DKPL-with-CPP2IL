namespace Mono.Security.Cryptography;

internal sealed class PKCS1
{
	private static Byte[] emptySHA1; //Field offset: 0x0
	private static Byte[] emptySHA256; //Field offset: 0x4
	private static Byte[] emptySHA384; //Field offset: 0x8
	private static Byte[] emptySHA512; //Field offset: 0xC

	private static PKCS1() { }

	private static bool Compare(Byte[] array1, Byte[] array2) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	public static Byte[] Decrypt_OAEP(RSA rsa, HashAlgorithm hash, Byte[] C) { }

	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	public static Byte[] Encrypt_OAEP(RSA rsa, HashAlgorithm hash, RandomNumberGenerator rng, Byte[] M) { }

	private static Byte[] GetEmptyHash(HashAlgorithm hash) { }

	public static Byte[] I2OSP(Byte[] x, int size) { }

	public static Byte[] I2OSP(int x, int size) { }

	public static Byte[] MGF1(HashAlgorithm hash, Byte[] mgfSeed, int maskLen) { }

	public static Byte[] OS2IP(Byte[] x) { }

	public static Byte[] RSADP(RSA rsa, Byte[] c) { }

	public static Byte[] RSAEP(RSA rsa, Byte[] m) { }

	public static Byte[] RSASP1(RSA rsa, Byte[] m) { }

	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	public static Byte[] Sign_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue) { }

	internal static Byte[] Sign_v15(RSA rsa, string hashName, Byte[] hashValue) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature) { }

	internal static bool Verify_v15(RSA rsa, string hashName, Byte[] hashValue, Byte[] signature) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

	private static Byte[] xor(Byte[] array1, Byte[] array2) { }

}

