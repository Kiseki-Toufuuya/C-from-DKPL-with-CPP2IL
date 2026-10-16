namespace UnityEngine.InputSystem.Processors;

public class StickDeadzoneProcessor : InputProcessor<Vector2>
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

	public StickDeadzoneProcessor() { }

	private float get_maxOrDefault() { }

	private float get_minOrDefault() { }

	private float GetDeadZoneAdjustedValue(float value) { }

	public virtual Vector2 Process(Vector2 value, InputControl control = null) { }

	public virtual string ToString() { }

}

