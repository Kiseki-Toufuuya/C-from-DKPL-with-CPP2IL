namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TemplateAsset : VisualElementAsset
{
	internal struct AttributeOverride
	{
		public string m_ElementName; //Field offset: 0x0
		public String[] m_NamesPath; //Field offset: 0x4
		public string m_AttributeName; //Field offset: 0x8
		public string m_Value; //Field offset: 0xC

		public bool NamesPathMatchesElementNamesPath(IList<String> elementNamesPath) { }

	}

	internal struct UxmlSerializedDataOverride
	{
		public int m_ElementId; //Field offset: 0x0
		public List<Int32> m_ElementIdsPath; //Field offset: 0x4
		[SerializeReference]
		public UxmlSerializedData m_SerializedData; //Field offset: 0x8

	}

	[SerializeField]
	private string m_TemplateAlias; //Field offset: 0x4C
	[SerializeField]
	private List<AttributeOverride> m_AttributeOverrides; //Field offset: 0x50
	[SerializeField]
	private List<UxmlSerializedDataOverride> m_SerializedDataOverride; //Field offset: 0x54
	[SerializeField]
	private List<SlotUsageEntry> m_SlotUsages; //Field offset: 0x58

	public List<AttributeOverride> attributeOverrides
	{
		 get { } //Length: 11
	}

	public List<UxmlSerializedDataOverride> serializedDataOverrides
	{
		 get { } //Length: 11
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> slotUsages
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 11
	}

	public List<AttributeOverride> get_attributeOverrides() { }

	public List<UxmlSerializedDataOverride> get_serializedDataOverrides() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> get_slotUsages() { }

	internal virtual VisualElement Instantiate(CreationContext cc) { }

}

