namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public struct GlobalKeyword
{
	internal readonly string m_Name; //Field offset: 0x0
	internal readonly uint m_Index; //Field offset: 0x4

	public virtual string ToString() { }

}

