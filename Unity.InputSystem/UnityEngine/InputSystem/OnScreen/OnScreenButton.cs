namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu("Input/On-Screen Button")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/OnScreen.html#on-screen-buttons")]
public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[InputControl(layout = "Button")]
	[SerializeField]
	private string m_ControlPath; //Field offset: 0x1C

	protected virtual string controlPathInternal
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public OnScreenButton() { }

	protected virtual string get_controlPathInternal() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected virtual void set_controlPathInternal(string value) { }

}

