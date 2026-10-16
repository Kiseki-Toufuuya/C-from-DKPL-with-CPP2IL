namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleRule
{
	[SerializeField]
	private StyleProperty[] m_Properties; //Field offset: 0x8
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int line; //Field offset: 0xC
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int customPropertiesCount; //Field offset: 0x10

	public StyleProperty[] properties
	{
		 get { } //Length: 11
	}

	public StyleRule() { }

	public StyleProperty[] get_properties() { }

}

