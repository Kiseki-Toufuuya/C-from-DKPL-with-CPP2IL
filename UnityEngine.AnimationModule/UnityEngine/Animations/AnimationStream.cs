namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
public struct AnimationStream
{
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	private IntPtr constant; //Field offset: 0x4
	private IntPtr input; //Field offset: 0x8
	private IntPtr output; //Field offset: 0xC
	private IntPtr workspace; //Field offset: 0x10
	private IntPtr inputStreamAccessor; //Field offset: 0x14
	private IntPtr animationHandleBinder; //Field offset: 0x18

}

