namespace UnityEngine.EventSystems;

public abstract class AbstractEventData
{
	protected bool m_Used; //Field offset: 0x8

	public override bool used
	{
		 get { } //Length: 11
	}

	protected AbstractEventData() { }

	public override bool get_used() { }

	public override void Reset() { }

	public override void Use() { }

}

