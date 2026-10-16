namespace System.Security.Cryptography;

internal static class Utils
{
	internal const int DefaultRsaProviderType = 1; //Field offset: 0x0
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		internal get { } //Length: 810
	}

	internal static bool _ProduceLegacyHmacValues() { }

	private static Utils() { }

	internal static bool CompareBigIntArrays(Byte[] lhs, Byte[] rhs) { }

	internal static int ConvertByteArrayToInt(Byte[] input) { }

	internal static Byte[] ConvertIntToByteArray(int dwInput) { }

	internal static void ConvertIntToByteArray(uint dwInput, ref Byte[] counter) { }

	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, Type[] parameterTypes) { }

	private static bool DoesRsaKeyOverrideSlowPath(Type t, string methodName, Type[] parameterTypes) { }

	internal static void DWORDFromBigEndian(UInt32* x, int digits, Byte* block) { }

	internal static void DWORDFromLittleEndian(UInt32* x, int digits, Byte* block) { }

	internal static void DWORDToBigEndian(Byte[] block, UInt32[] x, int digits) { }

	internal static void DWORDToLittleEndian(Byte[] block, UInt32[] x, int digits) { }

	internal static Byte[] FixupKeyParity(Byte[] key) { }

	internal static Byte[] GenerateRandom(int keySize) { }

	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	internal static Byte[] Int(uint i) { }

	internal static HashAlgorithmName OidToHashAlgorithmName(string oid) { }

	internal static void QuadWordFromBigEndian(UInt64* x, int digits, Byte* block) { }

	internal static void QuadWordToBigEndian(Byte[] block, UInt64[] x, int digits) { }

	internal static Byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, Byte[] encryptedData) { }

	internal static Byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, Byte[] data) { }

	internal static Byte[] RsaPkcs1Padding(RSA rsa, Byte[] oid, Byte[] hash) { }

}

