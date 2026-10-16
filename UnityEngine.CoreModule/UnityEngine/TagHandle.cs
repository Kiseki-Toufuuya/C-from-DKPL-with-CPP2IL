namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
public struct TagHandle
{
	private uint _tagIndex; //Field offset: 0x0

	private static string TagToString(uint tagIndex) { }

	private static void TagToString_Injected(uint tagIndex, out ManagedSpanWrapper ret) { }

	public virtual string ToString() { }

}

