namespace UnityEngine;

[NativeAsStruct]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAnimatorControllerParameter")]
[UsedByNativeCode]
public class AnimatorControllerParameter
{
	internal string m_Name; //Field offset: 0x8
	internal AnimatorControllerParameterType m_Type; //Field offset: 0xC
	internal float m_DefaultFloat; //Field offset: 0x10
	internal int m_DefaultInt; //Field offset: 0x14
	internal bool m_DefaultBool; //Field offset: 0x18

	public string name
	{
		 get { } //Length: 11
	}

	public AnimatorControllerParameter() { }

	public virtual bool Equals(object o) { }

	public string get_name() { }

	public virtual int GetHashCode() { }

}

