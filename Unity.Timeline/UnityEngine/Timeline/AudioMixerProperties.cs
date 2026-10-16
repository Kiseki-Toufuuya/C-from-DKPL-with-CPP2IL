namespace UnityEngine.Timeline;

internal class AudioMixerProperties : PlayableBehaviour
{
	[Range(0, 1)]
	public float volume; //Field offset: 0x8
	[Range(-1, 1)]
	public float stereoPan; //Field offset: 0xC
	[Range(0, 1)]
	public float spatialBlend; //Field offset: 0x10

	public AudioMixerProperties() { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

