namespace UnityEngine;

[MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
[NativeHeader("Modules/Animation/AvatarMask.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
public sealed class AvatarMask : object
{

	public int transformCount
	{
		 get { } //Length: 98
	}

	public AvatarMask() { }

	public int get_transformCount() { }

	private static int get_transformCount_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetBodyPart")]
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	private static bool GetHumanoidBodyPartActive_Injected(IntPtr _unity_self, AvatarMaskBodyPart index) { }

	public bool GetTransformActive(int index) { }

	public string GetTransformPath(int index) { }

	private static void GetTransformPath_Injected(IntPtr _unity_self, int index, out ManagedSpanWrapper ret) { }

	private float GetTransformWeight(int index) { }

	private static float GetTransformWeight_Injected(IntPtr _unity_self, int index) { }

	[FreeFunction("AnimationBindings::CreateAvatarMask")]
	private static void Internal_Create(AvatarMask self) { }

}

