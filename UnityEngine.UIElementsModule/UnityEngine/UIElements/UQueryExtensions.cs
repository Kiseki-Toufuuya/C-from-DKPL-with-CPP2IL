namespace UnityEngine.UIElements;

[Extension]
public static class UQueryExtensions
{
	private static UQueryState<VisualElement> SingleElementEmptyQuery; //Field offset: 0x0
	private static UQueryState<VisualElement> SingleElementNameQuery; //Field offset: 0x8
	private static UQueryState<VisualElement> SingleElementClassQuery; //Field offset: 0x10
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; //Field offset: 0x18
	private static UQueryState<VisualElement> SingleElementTypeQuery; //Field offset: 0x20
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; //Field offset: 0x28
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; //Field offset: 0x30
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; //Field offset: 0x38

	private static UQueryExtensions() { }

	[Extension]
	public static VisualElement Q(VisualElement e, string name = null, String[] classes) { }

	[Extension]
	public static T Q(VisualElement e, string name = null, string className = null) { }

	[Extension]
	public static VisualElement Q(VisualElement e, string name = null, string className = null) { }

	[Extension]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, String[] classes) { }

	[Extension]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, string className = null) { }

}

