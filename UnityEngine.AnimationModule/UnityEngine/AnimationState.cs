namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimationState.h")]
[UsedByNativeCode]
public sealed class AnimationState : TrackedReference
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(AnimationState animationState) { }

	}


	public AnimationClip clip
	{
		 get { } //Length: 110
	}

	public float normalizedTime
	{
		 set { } //Length: 80
	}

	public float speed
	{
		 set { } //Length: 80
	}

	public float time
	{
		 set { } //Length: 80
	}

	public AnimationState() { }

	public AnimationClip get_clip() { }

	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	public void set_normalizedTime(float value) { }

	private static void set_normalizedTime_Injected(IntPtr _unity_self, float value) { }

	public void set_speed(float value) { }

	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	public void set_time(float value) { }

	private static void set_time_Injected(IntPtr _unity_self, float value) { }

}

