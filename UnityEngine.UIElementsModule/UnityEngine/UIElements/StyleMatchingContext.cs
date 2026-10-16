namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleMatchingContext
{
	private List<StyleSheet> m_StyleSheetStack; //Field offset: 0x8
	public StyleVariableContext variableContext; //Field offset: 0xC
	public VisualElement currentElement; //Field offset: 0x10
	public Action<VisualElement, MatchResultInfo> processResult; //Field offset: 0x14
	public AncestorFilter ancestorFilter; //Field offset: 0x18

	public int styleSheetCount
	{
		 get { } //Length: 52
	}

	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) { }

	public void AddStyleSheet(StyleSheet sheet) { }

	public int get_styleSheetCount() { }

	public StyleSheet GetStyleSheetAt(int index) { }

	public void RemoveStyleSheetRange(int index, int count) { }

}

