namespace XeSys.uGUI;

public class UIWrapperButton : UIWrapperImage, IuGUIButton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass104_0
	{
		public Action<Int32, BaseEventData> on_select; //Field offset: 0x8
		public UIWrapperButton <>4__this; //Field offset: 0xC
		public Action<Int32, BaseEventData> on_deselect; //Field offset: 0x10

		public <>c__DisplayClass104_0() { }

		internal void <SetSelectableCallback>b__0(BaseEventData eventData) { }

		internal void <SetSelectableCallback>b__1(BaseEventData eventData) { }

	}

	private ButtonAnimType m_ButtonType; //Field offset: 0x20
	private int m_ButtonId; //Field offset: 0x24
	private string m_HitObjectName; //Field offset: 0x28
	private string m_ButtonObjectName; //Field offset: 0x2C
	private Action m_onClick; //Field offset: 0x30
	private Action<Int32> m_onClickVal; //Field offset: 0x34
	private Action<Int32> m_onClickPlaySeVal; //Field offset: 0x38
	private int m_ClickVal; //Field offset: 0x3C
	private Action<Int32> m_onClickEnd; //Field offset: 0x40
	private Action<Int32> m_onClickEndVal; //Field offset: 0x44
	private Action<TouchInfo> m_onTouch; //Field offset: 0x48
	private Action<TouchInfo, Int32> m_onTouchVal; //Field offset: 0x4C
	private bool m_IsWaitClickAnim; //Field offset: 0x50
	private bool m_IsDrag; //Field offset: 0x51
	private Animator m_Animator; //Field offset: 0x54
	protected AbsoluteLayout m_RootLayout; //Field offset: 0x58
	private uGUILayoutButtonBase m_Button; //Field offset: 0x5C
	private GameObject m_HitObject; //Field offset: 0x60
	private Graphic m_gra; //Field offset: 0x64
	private GameObject m_ButtonObject; //Field offset: 0x68
	private ViewBase m_ButtonView; //Field offset: 0x6C
	private LayoutuGUITweenAnimBehaviour m_TweenAnimBehaviour; //Field offset: 0x70

	public override GameObject ButtonHitObject
	{
		 get { } //Length: 27
		 set { } //Length: 56
	}

	public int ButtonId
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ButtonAnimType ButtonType
	{
		 get { } //Length: 11
	}

	public override int ClickVal
	{
		 get { } //Length: 11
		 set { } //Length: 26
	}

	public override bool CurrentTouch
	{
		 get { } //Length: 26
		 set { } //Length: 23
	}

	public override bool Enabled
	{
		 get { } //Length: 26
		 set { } //Length: 23
	}

	public string HitObjectName
	{
		 get { } //Length: 11
	}

	public override bool IsDrag
	{
		 get { } //Length: 11
		 set { } //Length: 26
	}

	public bool IsTouchStart
	{
		 get { } //Length: 26
	}

	public override bool IsWaitClickAnim
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override Action OnClick
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public Action<Int32> OnClickEnd
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public Action<Int32> OnClickEndVal
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public Action<Int32> OnClickPlaySeVal
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public override Action<Int32> OnClickVal
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public override Action<TouchInfo> OnTouchCallback
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public Action<TouchInfo, Int32> OnTouchValCallback
	{
		 get { } //Length: 11
		 set { } //Length: 56
	}

	public override int TouchId
	{
		 get { } //Length: 25
		 set { } //Length: 23
	}

	public UIWrapperButton() { }

	public void Action(State state, bool force) { }

	public override void Action(State state) { }

	public void ChgButtonSlice(int idx) { }

	public static UIWrapperButton CreateAnimatorButton(Animator animator, GameObject root, int btn_id, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	private uGUIAnimatorButton CreateAnimatorButton() { }

	public static UIWrapperButton CreateLayoutButton(AbsoluteLayout rootLayout, GameObject root, int btn_id, string hitObjName, string buttonViewName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	private uGUILayoutButton CreateLayoutButton() { }

	public static UIWrapperButton CreateTweenButton(GameObject root, int btn_id, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	private uGUITweenButton CreateTweenButton() { }

	public override GameObject get_ButtonHitObject() { }

	public int get_ButtonId() { }

	public ButtonAnimType get_ButtonType() { }

	public override int get_ClickVal() { }

	public override bool get_CurrentTouch() { }

	public override bool get_Enabled() { }

	public string get_HitObjectName() { }

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

	private void Init(ButtonAnimType buttonType, GameObject root, int btn_id, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick, Action<TouchInfo> onTouch, bool isDrag, Animator animator, AbsoluteLayout rootLayout) { }

	public void InitAnimatorButton(Animator animator, GameObject root, int btn_id, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public void InitLayoutButton(AbsoluteLayout rootLayout, GameObject root, int btn_id, string hitObjName, string buttonViewName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public void InitTweenAnimationStart() { }

	public void InitTweenButton(GameObject root, int btn_id, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public override bool IsEndAnim() { }

	public override void set_ButtonHitObject(GameObject value) { }

	public void set_ButtonId(int value) { }

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

	public void SetActive(bool flg) { }

	public void SetBtnColorAnim(ColorState state) { }

	public void SetBtnEnable(bool enable, bool force) { }

	public void SetBtnEnable(bool enable) { }

	public void SetChgSliceIdxData(State state, int idx) { }

	public void SetHitComponent(bool target) { }

	public void SetNoChgSlice() { }

	public void SetRaycastTarget(bool flg) { }

	public void SetSelectableCallback(Action<Int32, BaseEventData> on_select, Action<Int32, BaseEventData> on_deselect) { }

	public void SetStateAnimatorAnimData(State state, AnimatorControllData data) { }

	public void SetStateTweenAnimData(State state, int staidx, int endidx) { }

	public void SetStateViewAnimData(State state, LayoutAnimControllData data) { }

	public void StartAnimation(string startLabel, string endLabel) { }

	public void StartAnimatorAnimation(string state, int layer) { }

	public void StartTweenAnimation(string startLabel, string endLabel) { }

	public override DragState Touch(TouchInfo touchInfo) { }

	public override void Update() { }

}

