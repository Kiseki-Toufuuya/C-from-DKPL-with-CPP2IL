namespace UnityEngine;

internal class RuntimeTextSettings : TextSettings
{
	private static RuntimeTextSettings s_DefaultTextSettings; //Field offset: 0x0
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; //Field offset: 0x4

	internal static RuntimeTextSettings defaultTextSettings
	{
		internal get { } //Length: 148
	}

	public RuntimeTextSettings() { }

	internal static RuntimeTextSettings get_defaultTextSettings() { }

	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

}

