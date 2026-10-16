namespace UnityEngine.InputSystem.Processors;

public class ScaleVector3Processor : InputProcessor<Vector3>
{
	[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
	public float x; //Field offset: 0x8
	[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
	public float y; //Field offset: 0xC
	[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
	public float z; //Field offset: 0x10

	public ScaleVector3Processor() { }

	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	public virtual string ToString() { }

}

