namespace UnityEngine.UIElements.StyleSheets;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StylePropertyUtil
{
	internal static readonly Dictionary<String, StylePropertyId> s_NameToId; //Field offset: 0x0
	internal static readonly Dictionary<StylePropertyId, String> s_IdToName; //Field offset: 0x4
	internal static readonly Dictionary<String, String> s_UssNameToCSharpName; //Field offset: 0x8
	internal static readonly Dictionary<String, String> s_CSharpNameToUssName; //Field offset: 0xC
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; //Field offset: 0x10
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; //Field offset: 0x14

	private static StylePropertyUtil() { }

	public static bool IsAnimatable(StylePropertyId id) { }

	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

}

