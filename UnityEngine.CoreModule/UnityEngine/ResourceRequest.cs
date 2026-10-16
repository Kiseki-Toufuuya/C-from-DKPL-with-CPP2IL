namespace UnityEngine;

[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation
{
	internal string m_Path; //Field offset: 0x10
	internal Type m_Type; //Field offset: 0x14

	protected ResourceRequest(IntPtr ptr) { }

	protected override object GetResult() { }

}

