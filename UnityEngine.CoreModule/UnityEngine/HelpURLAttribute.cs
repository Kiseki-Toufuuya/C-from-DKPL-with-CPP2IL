namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[UsedByNativeCode]
public class HelpURLAttribute : Attribute
{
	internal readonly string m_Url; //Field offset: 0x8
	internal readonly bool m_Dispatcher; //Field offset: 0xC
	internal readonly string m_DispatchingFieldName; //Field offset: 0x10

	public HelpURLAttribute(string url) { }

}

