namespace XeApp.Game.Net;

public static class EmbeddedConstant
{
	public static readonly string ClientRootHash; //Field offset: 0x0
	public const int PlayerStorageFormatVersion = 14; //Field offset: 0x0
	public const int PlayerStorageFormatVersion_v1_4_0 = 9; //Field offset: 0x0
	public const int DefaultGameID = 262; //Field offset: 0x0
	private const int DefaultGameID_Final = 10001; //Field offset: 0x0
	private const int DefaultGameID_Develop = 262; //Field offset: 0x0
	private const int DefaultGameID_Preview = 71; //Field offset: 0x0
	public const int PlayerStorageFormatVersion_v1_4_1 = 10; //Field offset: 0x0
	private const int DefaultGameID_Alpha1_20200616 = 7; //Field offset: 0x0
	private const int DefaultGameID_Alpha1 = 5; //Field offset: 0x0
	private const int DefaultGameID_Fumen = 6; //Field offset: 0x0
	private const int DefaultGameID_UserTestDev = 9; //Field offset: 0x0
	public static readonly string ODMKey_AssetBaseUrl; //Field offset: 0x4
	public static readonly string ODMKey_AssetRootHash; //Field offset: 0x8
	public static readonly string AssetUploadListKey; //Field offset: 0xC
	public static readonly string AssetBaseURLKey; //Field offset: 0x10
	public static readonly string ODMGeneric_Boot_Key; //Field offset: 0x14
	public static readonly string ODMGeneric_SecureHash_Key; //Field offset: 0x18
	public static readonly string ODMGeneric_Signature_Key; //Field offset: 0x1C
	public static readonly string ODMGeneric_Questant_Key; //Field offset: 0x20
	public static readonly string OfficialSiteUrl; //Field offset: 0x24
	public static readonly int GrandEpisodeLastID_Chapter_1; //Field offset: 0x28
	public static readonly int GrandEpisodeLastID_Chapter_2; //Field offset: 0x2C
	public static readonly int GrandEpisodeID_Chapter_2_1; //Field offset: 0x30
	public static GuardLong EndOfServiceUnixTime; //Field offset: 0x38

	private static EmbeddedConstant() { }

}

