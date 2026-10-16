namespace XeSys.uGUI;

public abstract class uGUILayoutButtonBase : IuGUIButton
{
	internal enum DragState
	{
		Not = 0,
		Begin = 1,
		Doing = 2,
		End = 3,
	}

	internal enum State
	{
		Normal = 0,
		On = 1,
		Exit = 2,
		Decide = 3,
		Disable = 4,
		num = 5,
	}

	protected State m_state; //Field offset: 0x8
	private int m_TouchId; //Field offset: 0xC
	private bool m_IsTouchStart; //Field offset: 0x10
	private bool m_Enabled; //Field offset: 0x11
	private bool m_CurrentTouch; //Field offset: 0x12
	private GameObject m_ButtonHitObject; //Field offset: 0x14
	private bool m_IsWaitClickAnim; //Field offset: 0x18
	private Action m_onClick; //Field offset: 0x1C
	private Action<Int32> m_onClickEnd; //Field offset: 0x20
	private Action<Int32> m_OnClickVal; //Field offset: 0x24
	private Action<Int32> m_OnClickPlaySeVal; //Field offset: 0x28
	private Action<Int32> m_onClickEndVal; //Field offset: 0x2C
	private int m_ClickVal; //Field offset: 0x30
	private Action<TouchInfo> m_onTouch; //Field offset: 0x34
	private Action<TouchInfo, Int32> m_onTouchVal; //Field offset: 0x38
	private bool m_IsDrag; //Field offset: 0x3C

	public override GameObject ButtonHitObject
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override int ClickVal
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool CurrentTouch
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool Enabled
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool IsDrag
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsTouchStart
	{
		 get { } //Length: 11
	}

	public override bool IsWaitClickAnim
	{
		 get { } //Length: 11
		 set { } //Length: 12
	}

	public override Action OnClick
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Action<Int32> OnClickEnd
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Action<Int32> OnClickEndVal
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Action<Int32> OnClickPlaySeVal
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override Action<Int32> OnClickVal
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override Action<TouchInfo> OnTouchCallback
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Action<TouchInfo, Int32> OnTouchValCallback
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override int TouchId
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uGUILayoutButtonBase(GameObject buttonHitObject, Action onClick, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public void Action(State state, bool force) { }

	public override void Action(State state) { }

	public override void Clear() { }

	public override GameObject get_ButtonHitObject() { }

	public override int get_ClickVal() { }

	public override bool get_CurrentTouch() { }

	public override bool get_Enabled() { }

	public override bool get_IsDrag() { }

	public bool get_IsTouchStart() { }

	public override bool get_IsWaitClickAnim() { }

	public override Action get_OnClick() { }

	public Action<Int32> get_OnClickEnd() { }

	public Action<Int32> get_OnClickEndVal() { }

	public Action<Int32> get_OnClickPlaySeVal() { }

	public override Action<Int32> get_OnClickVal() { }

	public override Action<TouchInfo> get_OnTouchCallback() { }

	public Action<TouchInfo, Int32> get_OnTouchValCallback() { }

	public override int get_TouchId() { }

	public abstract bool IsEndAnim() { }

	public override void set_ButtonHitObject(GameObject value) { }

	public override void set_ClickVal(int value) { }

	public override void set_CurrentTouch(bool value) { }

	public override void set_Enabled(bool value) { }

	public override void set_IsDrag(bool value) { }

	public override void set_IsWaitClickAnim(bool value) { }

	public override void set_OnClick(Action value) { }

	public void set_OnClickEnd(Action<Int32> value) { }

	public void set_OnClickEndVal(Action<Int32> value) { }

	public void set_OnClickPlaySeVal(Action<Int32> value) { }

	public override void set_OnClickVal(Action<Int32> value) { }

	public override void set_OnTouchCallback(Action<TouchInfo> value) { }

	public void set_OnTouchValCallback(Action<TouchInfo, Int32> value) { }

	public override void set_TouchId(int value) { }

	protected abstract void StartAnim(State state) { }

	public override DragState Touch(TouchInfo touchInfo) { }

	public override void Update() { }

}

