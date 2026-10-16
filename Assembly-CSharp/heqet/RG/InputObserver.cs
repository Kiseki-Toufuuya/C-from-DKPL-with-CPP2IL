namespace Heqet.RG;

public class InputObserver
{
	internal class FireData
	{
		public int laneId; //Field offset: 0x8
		public int flame; //Field offset: 0xC

		public FireData(int laneId_) { }

	}

	private const int maxLane = 6; //Field offset: 0x0
	private const int KEY_UP = 1; //Field offset: 0x0
	private const int KEY_PUSH = 3; //Field offset: 0x0
	private const int KEY_PRESS = 5; //Field offset: 0x0
	private RhythmGame rhythmGame; //Field offset: 0x8
	private TouchObserver touchObserver; //Field offset: 0xC
	private bool initialized; //Field offset: 0x10
	private InputActionReference[] keyLanes; //Field offset: 0x14
	private List<FireData> fire; //Field offset: 0x18

	public InputObserver() { }

	public void AutoPress(int laneId) { }

	public void AutoPush(int laneId) { }

	public void AutoReset() { }

	public void AutoUp(int laneId) { }

	public void DoUpdate() { }

	public int GetAutoFrame(int laneId) { }

	public void Initialize(RhythmGame rhythmGame, TouchObserver touchObserver) { }

	private void OnRefresh() { }

	public void Terminate() { }

	public bool TriggerPress(int laneId) { }

	public bool TriggerPush(int laneId) { }

	public bool TriggerUp(int laneId) { }

}

