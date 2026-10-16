namespace UnityEngine;

[UsedByNativeCode]
public class TrackedReference
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AnimationModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x8

	protected TrackedReference() { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	public static bool op_Implicit(TrackedReference exists) { }

	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

}

