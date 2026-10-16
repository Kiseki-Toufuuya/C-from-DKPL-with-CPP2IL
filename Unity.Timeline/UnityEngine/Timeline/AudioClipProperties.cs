namespace UnityEngine.Timeline;

[NotKeyable]
internal class AudioClipProperties : PlayableBehaviour
{
	[Range(0, 1)]
	public float volume; //Field offset: 0x8

	public AudioClipProperties() { }

}

