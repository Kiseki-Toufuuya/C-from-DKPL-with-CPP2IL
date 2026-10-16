namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleProperty
{
	[SerializeField]
	private string m_Name; //Field offset: 0x8
	[SerializeField]
	private int m_Line; //Field offset: 0xC
	[SerializeField]
	private StyleValueHandle[] m_Values; //Field offset: 0x10
	internal bool isCustomProperty; //Field offset: 0x14
	internal bool requireVariableResolve; //Field offset: 0x15

	public string name
	{
		 get { } //Length: 11
	}

	public StyleValueHandle[] values
	{
		 get { } //Length: 11
	}

	public StyleProperty() { }

	public string get_name() { }

	public StyleValueHandle[] get_values() { }

}

