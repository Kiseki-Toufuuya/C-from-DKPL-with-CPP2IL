//Type is in global namespace

public class HeqetControls : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	internal struct DanmakuActions
	{
		private HeqetControls m_Wrapper; //Field offset: 0x0

		public InputAction AdvAuto
		{
			 get { } //Length: 25
		}

		public InputAction AdvCardNext
		{
			 get { } //Length: 25
		}

		public InputAction AdvCardPrev
		{
			 get { } //Length: 25
		}

		public InputAction AdvLog
		{
			 get { } //Length: 25
		}

		public InputAction AdvSkip
		{
			 get { } //Length: 25
		}

		public InputAction AdvUiOff
		{
			 get { } //Length: 25
		}

		public InputAction Cancel
		{
			 get { } //Length: 25
		}

		public InputAction Click
		{
			 get { } //Length: 25
		}

		public bool enabled
		{
			 get { } //Length: 43
		}

		public InputAction Function1
		{
			 get { } //Length: 25
		}

		public InputAction Function2
		{
			 get { } //Length: 25
		}

		public InputAction MiddleClick
		{
			 get { } //Length: 25
		}

		public InputAction Navigate
		{
			 get { } //Length: 25
		}

		public InputAction Point
		{
			 get { } //Length: 25
		}

		public InputAction RightClick
		{
			 get { } //Length: 25
		}

		public InputAction ScrollWheel
		{
			 get { } //Length: 25
		}

		public InputAction Submit
		{
			 get { } //Length: 25
		}

		public InputAction TabLeft
		{
			 get { } //Length: 25
		}

		public InputAction TabRight
		{
			 get { } //Length: 25
		}

		public InputAction TrackedDeviceOrientation
		{
			 get { } //Length: 25
		}

		public InputAction TrackedDevicePosition
		{
			 get { } //Length: 25
		}

		public DanmakuActions(HeqetControls wrapper) { }

		public void Disable() { }

		public void Enable() { }

		public InputActionMap Get() { }

		public InputAction get_AdvAuto() { }

		public InputAction get_AdvCardNext() { }

		public InputAction get_AdvCardPrev() { }

		public InputAction get_AdvLog() { }

		public InputAction get_AdvSkip() { }

		public InputAction get_AdvUiOff() { }

		public InputAction get_Cancel() { }

		public InputAction get_Click() { }

		public bool get_enabled() { }

		public InputAction get_Function1() { }

		public InputAction get_Function2() { }

		public InputAction get_MiddleClick() { }

		public InputAction get_Navigate() { }

		public InputAction get_Point() { }

		public InputAction get_RightClick() { }

		public InputAction get_ScrollWheel() { }

		public InputAction get_Submit() { }

		public InputAction get_TabLeft() { }

		public InputAction get_TabRight() { }

		public InputAction get_TrackedDeviceOrientation() { }

		public InputAction get_TrackedDevicePosition() { }

		public static InputActionMap op_Implicit(DanmakuActions set) { }

		public void SetCallbacks(IDanmakuActions instance) { }

	}

	internal interface IDanmakuActions
	{

		public void OnAdvAuto(CallbackContext context) { }

		public void OnAdvCardNext(CallbackContext context) { }

		public void OnAdvCardPrev(CallbackContext context) { }

		public void OnAdvLog(CallbackContext context) { }

		public void OnAdvSkip(CallbackContext context) { }

		public void OnAdvUiOff(CallbackContext context) { }

		public void OnCancel(CallbackContext context) { }

		public void OnClick(CallbackContext context) { }

		public void OnFunction1(CallbackContext context) { }

		public void OnFunction2(CallbackContext context) { }

		public void OnMiddleClick(CallbackContext context) { }

		public void OnNavigate(CallbackContext context) { }

		public void OnPoint(CallbackContext context) { }

		public void OnRightClick(CallbackContext context) { }

		public void OnScrollWheel(CallbackContext context) { }

		public void OnSubmit(CallbackContext context) { }

		public void OnTabLeft(CallbackContext context) { }

		public void OnTabRight(CallbackContext context) { }

		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	internal interface IKaguraActions
	{

		public void OnAdvAuto(CallbackContext context) { }

		public void OnAdvCardNext(CallbackContext context) { }

		public void OnAdvCardPrev(CallbackContext context) { }

		public void OnAdvLog(CallbackContext context) { }

		public void OnAdvSkip(CallbackContext context) { }

		public void OnAdvUiOff(CallbackContext context) { }

		public void OnCancel(CallbackContext context) { }

		public void OnClick(CallbackContext context) { }

		public void OnFunction1(CallbackContext context) { }

		public void OnFunction2(CallbackContext context) { }

		public void OnLane1(CallbackContext context) { }

		public void OnLane2(CallbackContext context) { }

		public void OnLane3(CallbackContext context) { }

		public void OnLane4(CallbackContext context) { }

		public void OnLane5(CallbackContext context) { }

		public void OnLane6(CallbackContext context) { }

		public void OnMiddleClick(CallbackContext context) { }

		public void OnNavigate(CallbackContext context) { }

		public void OnPoint(CallbackContext context) { }

		public void OnRightClick(CallbackContext context) { }

		public void OnScrollWheel(CallbackContext context) { }

		public void OnSubmit(CallbackContext context) { }

		public void OnTabLeft(CallbackContext context) { }

		public void OnTabRight(CallbackContext context) { }

		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	internal interface IUIActions
	{

		public void OnAdvAuto(CallbackContext context) { }

		public void OnAdvCardNext(CallbackContext context) { }

		public void OnAdvCardPrev(CallbackContext context) { }

		public void OnAdvLog(CallbackContext context) { }

		public void OnAdvSkip(CallbackContext context) { }

		public void OnAdvUiOff(CallbackContext context) { }

		public void OnCancel(CallbackContext context) { }

		public void OnClick(CallbackContext context) { }

		public void OnFunction1(CallbackContext context) { }

		public void OnFunction2(CallbackContext context) { }

		public void OnMiddleClick(CallbackContext context) { }

		public void OnNavigate(CallbackContext context) { }

		public void OnPoint(CallbackContext context) { }

		public void OnRightClick(CallbackContext context) { }

		public void OnScrollWheel(CallbackContext context) { }

		public void OnSubmit(CallbackContext context) { }

		public void OnTabLeft(CallbackContext context) { }

		public void OnTabRight(CallbackContext context) { }

		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	internal struct KaguraActions
	{
		private HeqetControls m_Wrapper; //Field offset: 0x0

		public InputAction AdvAuto
		{
			 get { } //Length: 25
		}

		public InputAction AdvCardNext
		{
			 get { } //Length: 25
		}

		public InputAction AdvCardPrev
		{
			 get { } //Length: 25
		}

		public InputAction AdvLog
		{
			 get { } //Length: 25
		}

		public InputAction AdvSkip
		{
			 get { } //Length: 25
		}

		public InputAction AdvUiOff
		{
			 get { } //Length: 25
		}

		public InputAction Cancel
		{
			 get { } //Length: 22
		}

		public InputAction Click
		{
			 get { } //Length: 22
		}

		public bool enabled
		{
			 get { } //Length: 40
		}

		public InputAction Function1
		{
			 get { } //Length: 25
		}

		public InputAction Function2
		{
			 get { } //Length: 25
		}

		public InputAction Lane1
		{
			 get { } //Length: 25
		}

		public InputAction Lane2
		{
			 get { } //Length: 25
		}

		public InputAction Lane3
		{
			 get { } //Length: 25
		}

		public InputAction Lane4
		{
			 get { } //Length: 25
		}

		public InputAction Lane5
		{
			 get { } //Length: 25
		}

		public InputAction Lane6
		{
			 get { } //Length: 25
		}

		public InputAction MiddleClick
		{
			 get { } //Length: 25
		}

		public InputAction Navigate
		{
			 get { } //Length: 22
		}

		public InputAction Point
		{
			 get { } //Length: 22
		}

		public InputAction RightClick
		{
			 get { } //Length: 25
		}

		public InputAction ScrollWheel
		{
			 get { } //Length: 25
		}

		public InputAction Submit
		{
			 get { } //Length: 22
		}

		public InputAction TabLeft
		{
			 get { } //Length: 25
		}

		public InputAction TabRight
		{
			 get { } //Length: 25
		}

		public InputAction TrackedDeviceOrientation
		{
			 get { } //Length: 25
		}

		public InputAction TrackedDevicePosition
		{
			 get { } //Length: 25
		}

		public KaguraActions(HeqetControls wrapper) { }

		public void Disable() { }

		public void Enable() { }

		public InputActionMap Get() { }

		public InputAction get_AdvAuto() { }

		public InputAction get_AdvCardNext() { }

		public InputAction get_AdvCardPrev() { }

		public InputAction get_AdvLog() { }

		public InputAction get_AdvSkip() { }

		public InputAction get_AdvUiOff() { }

		public InputAction get_Cancel() { }

		public InputAction get_Click() { }

		public bool get_enabled() { }

		public InputAction get_Function1() { }

		public InputAction get_Function2() { }

		public InputAction get_Lane1() { }

		public InputAction get_Lane2() { }

		public InputAction get_Lane3() { }

		public InputAction get_Lane4() { }

		public InputAction get_Lane5() { }

		public InputAction get_Lane6() { }

		public InputAction get_MiddleClick() { }

		public InputAction get_Navigate() { }

		public InputAction get_Point() { }

		public InputAction get_RightClick() { }

		public InputAction get_ScrollWheel() { }

		public InputAction get_Submit() { }

		public InputAction get_TabLeft() { }

		public InputAction get_TabRight() { }

		public InputAction get_TrackedDeviceOrientation() { }

		public InputAction get_TrackedDevicePosition() { }

		public static InputActionMap op_Implicit(KaguraActions set) { }

		public void SetCallbacks(IKaguraActions instance) { }

	}

	internal struct UIActions
	{
		private HeqetControls m_Wrapper; //Field offset: 0x0

		public InputAction AdvAuto
		{
			 get { } //Length: 22
		}

		public InputAction AdvCardNext
		{
			 get { } //Length: 22
		}

		public InputAction AdvCardPrev
		{
			 get { } //Length: 22
		}

		public InputAction AdvLog
		{
			 get { } //Length: 22
		}

		public InputAction AdvSkip
		{
			 get { } //Length: 22
		}

		public InputAction AdvUiOff
		{
			 get { } //Length: 22
		}

		public InputAction Cancel
		{
			 get { } //Length: 22
		}

		public InputAction Click
		{
			 get { } //Length: 22
		}

		public bool enabled
		{
			 get { } //Length: 40
		}

		public InputAction Function1
		{
			 get { } //Length: 22
		}

		public InputAction Function2
		{
			 get { } //Length: 22
		}

		public InputAction MiddleClick
		{
			 get { } //Length: 22
		}

		public InputAction Navigate
		{
			 get { } //Length: 22
		}

		public InputAction Point
		{
			 get { } //Length: 22
		}

		public InputAction RightClick
		{
			 get { } //Length: 22
		}

		public InputAction ScrollWheel
		{
			 get { } //Length: 22
		}

		public InputAction Submit
		{
			 get { } //Length: 22
		}

		public InputAction TabLeft
		{
			 get { } //Length: 22
		}

		public InputAction TabRight
		{
			 get { } //Length: 22
		}

		public InputAction TrackedDeviceOrientation
		{
			 get { } //Length: 22
		}

		public InputAction TrackedDevicePosition
		{
			 get { } //Length: 22
		}

		public UIActions(HeqetControls wrapper) { }

		public void Disable() { }

		public void Enable() { }

		public InputActionMap Get() { }

		public InputAction get_AdvAuto() { }

		public InputAction get_AdvCardNext() { }

		public InputAction get_AdvCardPrev() { }

		public InputAction get_AdvLog() { }

		public InputAction get_AdvSkip() { }

		public InputAction get_AdvUiOff() { }

		public InputAction get_Cancel() { }

		public InputAction get_Click() { }

		public bool get_enabled() { }

		public InputAction get_Function1() { }

		public InputAction get_Function2() { }

		public InputAction get_MiddleClick() { }

		public InputAction get_Navigate() { }

		public InputAction get_Point() { }

		public InputAction get_RightClick() { }

		public InputAction get_ScrollWheel() { }

		public InputAction get_Submit() { }

		public InputAction get_TabLeft() { }

		public InputAction get_TabRight() { }

		public InputAction get_TrackedDeviceOrientation() { }

		public InputAction get_TrackedDevicePosition() { }

		public static InputActionMap op_Implicit(UIActions set) { }

		public void SetCallbacks(IUIActions instance) { }

	}

	[CompilerGenerated]
	private readonly InputActionAsset <asset>k__BackingField; //Field offset: 0x8
	private readonly InputActionMap m_UI; //Field offset: 0xC
	private IUIActions m_UIActionsCallbackInterface; //Field offset: 0x10
	private readonly InputAction m_UI_Navigate; //Field offset: 0x14
	private readonly InputAction m_UI_Submit; //Field offset: 0x18
	private readonly InputAction m_UI_Cancel; //Field offset: 0x1C
	private readonly InputAction m_UI_Point; //Field offset: 0x20
	private readonly InputAction m_UI_Click; //Field offset: 0x24
	private readonly InputAction m_UI_ScrollWheel; //Field offset: 0x28
	private readonly InputAction m_UI_MiddleClick; //Field offset: 0x2C
	private readonly InputAction m_UI_RightClick; //Field offset: 0x30
	private readonly InputAction m_UI_TrackedDevicePosition; //Field offset: 0x34
	private readonly InputAction m_UI_TrackedDeviceOrientation; //Field offset: 0x38
	private readonly InputAction m_UI_Function1; //Field offset: 0x3C
	private readonly InputAction m_UI_Function2; //Field offset: 0x40
	private readonly InputAction m_UI_TabLeft; //Field offset: 0x44
	private readonly InputAction m_UI_TabRight; //Field offset: 0x48
	private readonly InputAction m_UI_AdvSkip; //Field offset: 0x4C
	private readonly InputAction m_UI_AdvAuto; //Field offset: 0x50
	private readonly InputAction m_UI_AdvLog; //Field offset: 0x54
	private readonly InputAction m_UI_AdvUiOff; //Field offset: 0x58
	private readonly InputAction m_UI_AdvCardNext; //Field offset: 0x5C
	private readonly InputAction m_UI_AdvCardPrev; //Field offset: 0x60
	private readonly InputActionMap m_Kagura; //Field offset: 0x64
	private IKaguraActions m_KaguraActionsCallbackInterface; //Field offset: 0x68
	private readonly InputAction m_Kagura_Navigate; //Field offset: 0x6C
	private readonly InputAction m_Kagura_Submit; //Field offset: 0x70
	private readonly InputAction m_Kagura_Cancel; //Field offset: 0x74
	private readonly InputAction m_Kagura_Point; //Field offset: 0x78
	private readonly InputAction m_Kagura_Click; //Field offset: 0x7C
	private readonly InputAction m_Kagura_ScrollWheel; //Field offset: 0x80
	private readonly InputAction m_Kagura_MiddleClick; //Field offset: 0x84
	private readonly InputAction m_Kagura_RightClick; //Field offset: 0x88
	private readonly InputAction m_Kagura_TrackedDevicePosition; //Field offset: 0x8C
	private readonly InputAction m_Kagura_TrackedDeviceOrientation; //Field offset: 0x90
	private readonly InputAction m_Kagura_Function1; //Field offset: 0x94
	private readonly InputAction m_Kagura_Function2; //Field offset: 0x98
	private readonly InputAction m_Kagura_TabLeft; //Field offset: 0x9C
	private readonly InputAction m_Kagura_TabRight; //Field offset: 0xA0
	private readonly InputAction m_Kagura_AdvSkip; //Field offset: 0xA4
	private readonly InputAction m_Kagura_AdvAuto; //Field offset: 0xA8
	private readonly InputAction m_Kagura_AdvLog; //Field offset: 0xAC
	private readonly InputAction m_Kagura_AdvUiOff; //Field offset: 0xB0
	private readonly InputAction m_Kagura_AdvCardNext; //Field offset: 0xB4
	private readonly InputAction m_Kagura_AdvCardPrev; //Field offset: 0xB8
	private readonly InputAction m_Kagura_Lane1; //Field offset: 0xBC
	private readonly InputAction m_Kagura_Lane2; //Field offset: 0xC0
	private readonly InputAction m_Kagura_Lane3; //Field offset: 0xC4
	private readonly InputAction m_Kagura_Lane4; //Field offset: 0xC8
	private readonly InputAction m_Kagura_Lane5; //Field offset: 0xCC
	private readonly InputAction m_Kagura_Lane6; //Field offset: 0xD0
	private readonly InputActionMap m_Danmaku; //Field offset: 0xD4
	private IDanmakuActions m_DanmakuActionsCallbackInterface; //Field offset: 0xD8
	private readonly InputAction m_Danmaku_Navigate; //Field offset: 0xDC
	private readonly InputAction m_Danmaku_Submit; //Field offset: 0xE0
	private readonly InputAction m_Danmaku_Cancel; //Field offset: 0xE4
	private readonly InputAction m_Danmaku_Point; //Field offset: 0xE8
	private readonly InputAction m_Danmaku_Click; //Field offset: 0xEC
	private readonly InputAction m_Danmaku_ScrollWheel; //Field offset: 0xF0
	private readonly InputAction m_Danmaku_MiddleClick; //Field offset: 0xF4
	private readonly InputAction m_Danmaku_RightClick; //Field offset: 0xF8
	private readonly InputAction m_Danmaku_TrackedDevicePosition; //Field offset: 0xFC
	private readonly InputAction m_Danmaku_TrackedDeviceOrientation; //Field offset: 0x100
	private readonly InputAction m_Danmaku_Function1; //Field offset: 0x104
	private readonly InputAction m_Danmaku_Function2; //Field offset: 0x108
	private readonly InputAction m_Danmaku_TabLeft; //Field offset: 0x10C
	private readonly InputAction m_Danmaku_TabRight; //Field offset: 0x110
	private readonly InputAction m_Danmaku_AdvSkip; //Field offset: 0x114
	private readonly InputAction m_Danmaku_AdvAuto; //Field offset: 0x118
	private readonly InputAction m_Danmaku_AdvLog; //Field offset: 0x11C
	private readonly InputAction m_Danmaku_AdvUiOff; //Field offset: 0x120
	private readonly InputAction m_Danmaku_AdvCardNext; //Field offset: 0x124
	private readonly InputAction m_Danmaku_AdvCardPrev; //Field offset: 0x128

	public InputActionAsset asset
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 46
		 set { } //Length: 59
	}

	public override IEnumerable<InputBinding> bindings
	{
		 get { } //Length: 34
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		 get { } //Length: 59
	}

	public DanmakuActions Danmaku
	{
		 get { } //Length: 27
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		 get { } //Length: 49
		 set { } //Length: 43
	}

	public KaguraActions Kagura
	{
		 get { } //Length: 27
	}

	public UIActions UI
	{
		 get { } //Length: 27
	}

	public HeqetControls() { }

	public override bool Contains(InputAction action) { }

	public override void Disable() { }

	public override void Dispose() { }

	public override void Enable() { }

	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	public override int FindBinding(InputBinding bindingMask, out InputAction action) { }

	[CompilerGenerated]
	public InputActionAsset get_asset() { }

	public override Nullable<InputBinding> get_bindingMask() { }

	public override IEnumerable<InputBinding> get_bindings() { }

	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	public DanmakuActions get_Danmaku() { }

	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	public KaguraActions get_Kagura() { }

	public UIActions get_UI() { }

	public override IEnumerator<InputAction> GetEnumerator() { }

	public override void set_bindingMask(Nullable<InputBinding> value) { }

	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

