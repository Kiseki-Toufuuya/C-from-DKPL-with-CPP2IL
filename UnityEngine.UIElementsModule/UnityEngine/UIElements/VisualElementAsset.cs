namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
{
	[SerializeField]
	private string m_Name; //Field offset: 0x28
	[SerializeField]
	private int m_RuleIndex; //Field offset: 0x2C
	[SerializeField]
	private string m_Text; //Field offset: 0x30
	[SerializeField]
	private PickingMode m_PickingMode; //Field offset: 0x34
	[SerializeField]
	private String[] m_Classes; //Field offset: 0x38
	[SerializeField]
	private List<String> m_StylesheetPaths; //Field offset: 0x3C
	[SerializeField]
	private List<StyleSheet> m_Stylesheets; //Field offset: 0x40
	[SerializeReference]
	internal UxmlSerializedData m_SerializedData; //Field offset: 0x44
	[SerializeField]
	private bool m_SkipClone; //Field offset: 0x48

	public String[] classes
	{
		 get { } //Length: 11
	}

	public bool hasStylesheetPaths
	{
		 get { } //Length: 15
	}

	public bool hasStylesheets
	{
		 get { } //Length: 15
	}

	public int ruleIndex
	{
		 get { } //Length: 11
	}

	public UxmlSerializedData serializedData
	{
		 get { } //Length: 11
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool skipClone
	{
		internal get { } //Length: 11
	}

	public List<String> stylesheetPaths
	{
		 get { } //Length: 101
	}

	public List<StyleSheet> stylesheets
	{
		 get { } //Length: 101
	}

	public String[] get_classes() { }

	public bool get_hasStylesheetPaths() { }

	public bool get_hasStylesheets() { }

	public int get_ruleIndex() { }

	public UxmlSerializedData get_serializedData() { }

	internal bool get_skipClone() { }

	public List<String> get_stylesheetPaths() { }

	public List<StyleSheet> get_stylesheets() { }

	private static bool IdsPathMatchesAttributeOverrideIdsPath(List<Int32> idsPath, List<Int32> attributeOverrideIdsPath, int templateId) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override VisualElement Instantiate(CreationContext cc) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public virtual string ToString() { }

}

