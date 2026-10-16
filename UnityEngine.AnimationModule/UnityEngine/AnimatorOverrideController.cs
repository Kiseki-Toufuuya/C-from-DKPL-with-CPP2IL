namespace UnityEngine;

[DefaultMember("Item")]
[HelpURL("AnimatorOverrideController")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0xC

	public string Item
	{
		 set { } //Length: 16
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		[NativeMethod("SetAnimatorController")]
		 set { } //Length: 145
	}

	public AnimatorOverrideController() { }

	[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	private static void Internal_Create_Injected(AnimatorOverrideController self, IntPtr controller) { }

	[NativeMethod("SetClip")]
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	private static void Internal_SetClipByName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, IntPtr clip) { }

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

	public void set_Item(string name, AnimationClip value) { }

	[NativeMethod("SetAnimatorController")]
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

}

