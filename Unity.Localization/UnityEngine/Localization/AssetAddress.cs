namespace UnityEngine.Localization;

internal static class AssetAddress
{
	private const string k_SubAssetEntryStartBracket = "["; //Field offset: 0x0
	private const string k_SubAssetEntryEndBracket = "]"; //Field offset: 0x0

	public static string FormatAddress(string guid, string subAssetName) { }

	public static string GetGuid(string address) { }

	public static string GetSubAssetName(string address) { }

	public static bool IsSubAsset(string address) { }

}

