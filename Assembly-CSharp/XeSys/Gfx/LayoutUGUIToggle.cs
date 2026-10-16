namespace XeSys.Gfx;

public class LayoutUGUIToggle : LayoutUGUIButtonBase
{
	[SerializeField]
	private Toggle m_toggle; //Field offset: 0x2C
	public ToggleEvent onValueChanged; //Field offset: 0x30
	private bool m_isPrevAnim; //Field offset: 0x34

	public Toggle Toggle
	{
		 get { } //Length: 11
	}

	public LayoutUGUIToggle() { }

	public Toggle get_Toggle() { }

	public void InitializeOnPaste(Toggle toggle) { }

	public void OnValueChanged(bool on) { }

	protected virtual void StartDecideAnim() { }

	protected virtual void StartDefaultAnim() { }

	protected virtual void StartDisableAnime() { }

	protected virtual void StartPressAnim() { }

	protected virtual void StartReleaseAnim() { }

}

