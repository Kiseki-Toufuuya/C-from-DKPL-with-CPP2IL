namespace XeApp.Game;

public class DebugCheatMenuTrigger
{
	private const float THRESHOLD = 0.2; //Field offset: 0x0
	public bool IsOn; //Field offset: 0x8
	public bool IsTriggerDown; //Field offset: 0x9
	private float SaveDistance; //Field offset: 0xC

	public DebugCheatMenuTrigger() { }

	public bool IsFirstAction() { }

	public bool IsSecondAction(bool isOpen) { }

	public bool Update(bool isOpen) { }

}

