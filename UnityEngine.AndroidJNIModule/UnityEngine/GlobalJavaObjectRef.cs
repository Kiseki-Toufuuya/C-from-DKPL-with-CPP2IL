namespace UnityEngine;

internal class GlobalJavaObjectRef
{
	private bool m_disposed; //Field offset: 0x8
	protected IntPtr m_jobject; //Field offset: 0xC

	public GlobalJavaObjectRef(IntPtr jobject) { }

	public void Dispose() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

}

