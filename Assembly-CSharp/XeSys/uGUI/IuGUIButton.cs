namespace XeSys.uGUI;

public interface IuGUIButton
{

	public GameObject ButtonHitObject
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int ClickVal
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool CurrentTouch
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool Enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsDrag
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsWaitClickAnim
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Action OnClick
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Action<Int32> OnClickVal
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Action<TouchInfo> OnTouchCallback
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int TouchId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Action(State state) { }

	public GameObject get_ButtonHitObject() { }

	public int get_ClickVal() { }

	public bool get_CurrentTouch() { }

	public bool get_Enabled() { }

	public bool get_IsDrag() { }

	public bool get_IsWaitClickAnim() { }

	public Action get_OnClick() { }

	public Action<Int32> get_OnClickVal() { }

	public Action<TouchInfo> get_OnTouchCallback() { }

	public int get_TouchId() { }

	public bool IsEndAnim() { }

	public void set_ButtonHitObject(GameObject value) { }

	public void set_ClickVal(int value) { }

	public void set_CurrentTouch(bool value) { }

	public void set_Enabled(bool value) { }

	public void set_IsDrag(bool value) { }

	public void set_IsWaitClickAnim(bool value) { }

	public void set_OnClick(Action value) { }

	public void set_OnClickVal(Action<Int32> value) { }

	public void set_OnTouchCallback(Action<TouchInfo> value) { }

	public void set_TouchId(int value) { }

	public DragState Touch(TouchInfo touchInfo) { }

	public void Update() { }

}

