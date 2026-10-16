namespace UnityEngine.Localization;

internal class AddressHelper
{
	private const char k_Separator = '\u5F'; //Field offset: 0x0
	private const string k_AssetLabelPrefix = "Locale-"; //Field offset: 0x0

	public AddressHelper() { }

	public static string FormatAssetLabel(LocaleIdentifier localeIdentifier) { }

	public static string GetSharedTableAddress(string tableName) { }

	public static string GetTableAddress(string tableName, LocaleIdentifier localeId) { }

	public static bool IsLocaleLabel(string label) { }

	public static LocaleIdentifier LocaleLabelToId(string label) { }

	public static bool TryGetLocaleLabelToId(string label, out LocaleIdentifier localeId) { }

}

