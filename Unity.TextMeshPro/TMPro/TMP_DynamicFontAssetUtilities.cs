namespace TMPro;

internal class TMP_DynamicFontAssetUtilities
{
	internal struct FontReference
	{
		public string familyName; //Field offset: 0x0
		public string styleName; //Field offset: 0x4
		public int faceIndex; //Field offset: 0x8
		public string filePath; //Field offset: 0xC
		public ulong hashCode; //Field offset: 0x10

		public FontReference(string fontFilePath, string faceNameAndStyle, int index) { }

	}

	private static TMP_DynamicFontAssetUtilities s_Instance; //Field offset: 0x0
	private Dictionary<UInt64, FontReference> s_SystemFontLookup; //Field offset: 0x8
	private String[] s_SystemFontPaths; //Field offset: 0xC
	private uint s_RegularStyleNameHashCode; //Field offset: 0x10

	private static TMP_DynamicFontAssetUtilities() { }

	public TMP_DynamicFontAssetUtilities() { }

	private void InitializeSystemFontReferenceCache() { }

	public static bool TryGetSystemFontReference(string familyName, out FontReference fontRef) { }

	public static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef) { }

}

