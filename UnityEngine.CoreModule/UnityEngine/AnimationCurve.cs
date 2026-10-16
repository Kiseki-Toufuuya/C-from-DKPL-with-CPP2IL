namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	public static class BindingsMarshaller
	{

		public static AnimationCurve ConvertToManaged(IntPtr ptr) { }

		public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x8
	private bool m_RequiresNativeCleanup; //Field offset: 0xC

	public Keyframe Item
	{
		 get { } //Length: 145
	}

	public Keyframe[] keys
	{
		 get { } //Length: 16
		 set { } //Length: 192
	}

	public int length
	{
		[NativeMethod("GetKeyCount", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal AnimationCurve(IntPtr ptr, bool ownMemory) { }

	[RequiredByNativeCode]
	public AnimationCurve() { }

	public AnimationCurve(Keyframe[] keys) { }

	public int AddKey(Keyframe key) { }

	[NativeMethod("AddKey", IsThreadSafe = True)]
	private int AddKey_Internal(Keyframe key) { }

	private static int AddKey_Internal_Injected(IntPtr _unity_self, in Keyframe key) { }

	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	public override bool Equals(AnimationCurve other) { }

	public virtual bool Equals(object o) { }

	[ThreadSafe]
	public float Evaluate(float time) { }

	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	protected virtual void Finalize() { }

	public Keyframe get_Item(int index) { }

	public Keyframe[] get_keys() { }

	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	public int get_length() { }

	private static int get_length_Injected(IntPtr _unity_self) { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	public virtual int GetHashCode() { }

	private static int GetHashCode_Injected(IntPtr _unity_self) { }

	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	private Keyframe GetKey(int index) { }

	private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret) { }

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private Keyframe[] GetKeys() { }

	private static void GetKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	private bool Internal_Equals(IntPtr other) { }

	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	public void set_keys(Keyframe[] value) { }

	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private void SetKeys(Keyframe[] keys) { }

	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keys) { }

}

