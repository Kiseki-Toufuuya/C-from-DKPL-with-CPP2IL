namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	public float pitch
	{
		 get { } //Length: 136
		 set { } //Length: 143
	}

	public float volume
	{
		 get { } //Length: 102
		 set { } //Length: 4909
	}

	public AudioSource() { }

	public float get_pitch() { }

	public float get_volume() { }

	private static float get_volume_Injected(IntPtr _unity_self) { }

	public void GetOutputData(Single[] samples, int channel) { }

	private static void GetOutputDataHelper(AudioSource source, out Single[] samples, int channel) { }

	private static void GetOutputDataHelper_Injected(IntPtr source, out BlittableArrayWrapper samples, int channel) { }

	private static float GetPitch(AudioSource source) { }

	private static float GetPitch_Injected(IntPtr source) { }

	public void set_pitch(float value) { }

	public void set_volume(float value) { }

	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	private static void SetPitch_Injected(IntPtr source, float pitch) { }

}

