namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Hold")]
public class HoldInteraction : IInputInteraction
{
	public float duration; //Field offset: 0x8
	public float pressPoint; //Field offset: 0xC
	private double m_TimePressed; //Field offset: 0x10

	private float durationOrDefault
	{
		private get { } //Length: 98
	}

	private float pressPointOrDefault
	{
		private get { } //Length: 66
	}

	public HoldInteraction() { }

	private float get_durationOrDefault() { }

	private float get_pressPointOrDefault() { }

	public override void Process(ref InputInteractionContext context) { }

	public override void Reset() { }

}

