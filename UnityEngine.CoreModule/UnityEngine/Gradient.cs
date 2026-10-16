namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	public static class BindingsMarshaller
	{

		public static Gradient ConvertToManaged(IntPtr ptr) { }

		public static IntPtr ConvertToNative(Gradient graident) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x8
	private bool m_RequiresNativeCleanup; //Field offset: 0xC

	public GradientColorKey[] colorKeys
	{
		[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 get { } //Length: 284
	}

	[RequiredByNativeCode]
	public Gradient() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal Gradient(IntPtr ptr) { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	private static void Cleanup_Injected(IntPtr _unity_self) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Gradient other) { }

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	public Color Evaluate(float time) { }

	private static void Evaluate_Injected(IntPtr _unity_self, float time, out Color ret) { }

	protected virtual void Finalize() { }

	[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public GradientColorKey[] get_colorKeys() { }

	private static void get_colorKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	public virtual int GetHashCode() { }

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	private bool Internal_Equals(IntPtr other) { }

	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

}

