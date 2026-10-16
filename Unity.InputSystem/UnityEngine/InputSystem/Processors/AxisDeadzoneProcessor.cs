namespace UnityEngine.InputSystem.Processors;

public class AxisDeadzoneProcessor : InputProcessor<Single>
{
	public float min; //Field offset: 0x8
	public float max; //Field offset: 0xC

	private float maxOrDefault
	{
		private get { } //Length: 102
	}

	private float minOrDefault
	{
		private get { } //Length: 102
	}

	public AxisDeadzoneProcessor() { }

	private float get_maxOrDefault() { }

	private float get_minOrDefault() { }

	public virtual float Process(float value, InputControl control = null) { }

	public virtual string ToString() { }

}

