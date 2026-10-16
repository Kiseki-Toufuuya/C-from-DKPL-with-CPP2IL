namespace XeSys.Gfx;

public class RenderSettings : ScriptableObject
{
	internal enum SleepTimeoutId
	{
		NeverSleep = -1,
		SystemSetting = -2,
	}

	public int baseWidth; //Field offset: 0xC
	public int baseHeight; //Field offset: 0x10
	public uGUIFader fader; //Field offset: 0x14
	public uGUILetterBoxController letterBox; //Field offset: 0x18
	public bool createSystemCanvas; //Field offset: 0x1C
	public string systemCanvasName; //Field offset: 0x20
	public int systemCanvasSortingOrder; //Field offset: 0x24
	public SleepTimeoutId sleepTimeout; //Field offset: 0x28

	public RenderSettings() { }

	public void CopyTo(RenderSettings _target) { }

}

