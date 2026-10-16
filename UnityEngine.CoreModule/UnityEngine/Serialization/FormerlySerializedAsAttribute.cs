namespace UnityEngine.Serialization;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True, Inherited = False)]
[RequiredByNativeCode]
public class FormerlySerializedAsAttribute : Attribute
{
	private string m_oldName; //Field offset: 0x8

	public FormerlySerializedAsAttribute(string oldName) { }

}

