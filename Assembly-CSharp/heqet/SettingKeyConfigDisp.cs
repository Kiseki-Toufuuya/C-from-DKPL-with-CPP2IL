namespace Heqet;

public class SettingKeyConfigDisp : SettingDispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, BaseEventData> <>9__62_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitUguiOther>b__62_0(int _id, BaseEventData _data) { }

	}

	internal enum eButtonId
	{
		Kagura = 0,
		Danmaku = 1,
		ScreenMask = 2,
		Decide = 3,
		Reset = 4,
	}

	private enum eCommonLayerId
	{
		Set1_Kagura_Keybord = 0,
		Set2_Kagura_Keybord = 1,
		Set1_Kagura_Gamepad = 2,
		Set2_Kagura_Gamepad = 3,
		Set1_Danmaku_Keybord = 4,
		Set2_Danmaku_Keybord = 5,
		Set1_Danmaku_Gamepad = 6,
		Set2_Danmaku_Gamepad = 7,
		Preset = 8,
		Button_Kagura = 9,
		Button_Danmaku = 10,
		Active_Kagura = 11,
		Active_Danmaku = 12,
	}

	private enum eGameMode
	{
		Kagura = 0,
		Danmaku = 1,
	}

	private enum eImageId
	{
		Max = 0,
	}

	private enum eInputMode
	{
		Keybord = 0,
		Gamepad = 1,
	}

	internal enum ePresetType
	{
		Preset1 = 0,
		Preset2 = 1,
		Custom = 2,
	}

	private enum eTextId
	{
		KAGURA_LABEL = 0,
		DANMAKU_LABEL = 1,
		KEYBORD_LABEL = 2,
		GAMEPAD_LABEL = 3,
		CONTROLL_TYPE_LABEL = 4,
		DECIDE_BUTTON_LABEL = 5,
		RESET_BUTTON_LABEL = 6,
		KEYBORD_SET_ONE_LABEL = 7,
		KEYBORD_SET_TWO_LABEL = 8,
		GAMEPAD_SET_ONE_LABEL = 9,
		GAMEPAD_SET_TWO_LABEL = 10,
		SCREEN_MASK_LABEL = 11,
	}

	private class InputBindingWork
	{
		public int ButtonId; //Field offset: 0x8
		public string ActionName; //Field offset: 0xC
		public string BindingName; //Field offset: 0x10

		public InputBindingWork() { }

	}

	internal class SetupParam
	{
		public int PrisetType; //Field offset: 0x8
		public string InputActionCustomJson; //Field offset: 0xC

		public SetupParam() { }

	}

	private const int KAGURA_KEYCONFIG_NUM = 6; //Field offset: 0x0
	private const int DANMAKU_KEYCONFIG_NUM = 7; //Field offset: 0x0
	private const string BINDING_BUTTON_NAME = "/binding_button_{0}/btn_bind"; //Field offset: 0x0
	public const string PRESET2_JSON = "{"bindings":[{"action":"InGame/KaguraLane1","id":"58f61d9e-6a9c-43bc-86ec-8a4947e8659d","path":"<Gamepad>/leftTrigger","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane1","id":"b2126f75-bbfa-4804-826c-1e762b046836","path":"<Keyboard>/d","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane2","id":"33c0bc70-31f2-43d2-a96d-d3156362ca20","path":"<Gamepad>/leftShoulder","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane2","id":"c69b3e6d-6e03-47a4-b0c7-5607dd84765c","path":"<Keyboard>/f","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane3","id":"21ee5ead-99f9-422b-a66b-afcc34e49059","path":"<Gamepad>/dpad/up","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane3","id":"74e93127-3573-4993-9b6d-f9038e2cc184","path":"<Keyboard>/g","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane4","id":"d945bccb-a4a9-4b58-88f1-a8a4af763945","path":"<Gamepad>/buttonNorth","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane4","id":"75f846be-8b64-42d8-95af-a9ffd49fa15b","path":"<Keyboard>/h","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane5","id":"60f0fc03-3062-499a-bfac-5a066e762a25","path":"<Gamepad>/rightShoulder","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane5","id":"683585c5-4d63-486a-8fc7-d24495de1c78","path":"<Keyboard>/j","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane6","id":"2383b65a-a8de-41ed-84ff-c90f730d2e9e","path":"<Gamepad>/rightTrigger","interactions":"null","processors":"null"},{"action":"InGame/KaguraLane6","id":"9db30e99-97bf-43a6-bb1e-310aafa127c9","path":"<Keyboard>/k","interactions":"null","processors":"null"},{"action":"InGame/DanmakuLane1","id":"0ea59588-b4e8-471a-bca5-53c7b81dd84b","path":"<Keyboard>/comma","interactions":"null","processors":"null"},{"action":"InGame/DanmakuLane2","id":"de50347b-44bb-4e9d-9b68-673ea0db6c78","path":"<Keyboard>/period","interactions":"null","processors":"null"},{"action":"InGame/DanmakuLane3","id":"c6fe6d00-4ed0-4315-a9ed-3824cbdad448","path":"<Keyboard>/slash","interactions":"null","processors":"null"},{"action":"InGame/DanmakuLane4","id":"f13f39f0-0480-4bf5-a7a6-42b0dd7d2f31","path":"<Keyboard>/OEM2","interactions":"null","processors":"null"},{"action":"InGame/Bomb","id":"e01ca3be-956e-4998-b223-c550e8de0182","path":"<Keyboard>/leftShift","interactions":"null","processors":"null"}]}"; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private readonly int ROOT_KAGURA_GAMEPAD_BUTTON_INDEX; //Field offset: 0x170
	private readonly int ROOT_DANMAKU_GAMEPAD_BUTTON_INDEX; //Field offset: 0x174
	private string m_InputActionCustomJson; //Field offset: 0x178
	private string m_InputActionCustomJsonBuf; //Field offset: 0x17C
	private String[] CommonLayerList; //Field offset: 0x180
	private String[] m_ButtonDataList; //Field offset: 0x184
	private String[] m_KaguraKeyBindingButtonRootList; //Field offset: 0x188
	private String[] m_DanmakuKeyBindingButtonRootList; //Field offset: 0x18C
	[CompilerGenerated]
	private Action<Int32> <OnPressButton>k__BackingField; //Field offset: 0x190
	private int m_currentButtonId; //Field offset: 0x194
	private Dictionary<Int32, RebindUI> m_binding_list; //Field offset: 0x198
	private eGameMode m_GameMode; //Field offset: 0x19C
	private UIWrapperButton m_ScreenMask; //Field offset: 0x1A0
	private string m_InputActionPreset1Json; //Field offset: 0x1A4
	private string m_InputActionPreset2Json; //Field offset: 0x1A8
	private List<InputBindingWork> m_KaguraInputBindingKeybordWork; //Field offset: 0x1AC
	private List<InputBindingWork> m_KaguraInputBindingGamepadWork; //Field offset: 0x1B0
	private List<InputBindingWork> m_DanmakuInputBindingKeybordWork; //Field offset: 0x1B4
	private List<InputBindingWork> m_DanmakuInputBindingGamepadWork; //Field offset: 0x1B8
	private ePresetType m_PresetType; //Field offset: 0x1BC
	private List<Int32> m_KaguraButtonIds; //Field offset: 0x1C0
	private List<Int32> m_DanmakuButtonIds; //Field offset: 0x1C4
	private UIWrapperButton m_DecideButton; //Field offset: 0x1C8
	private UIWrapperButton m_ResetButton; //Field offset: 0x1CC
	[CompilerGenerated]
	private Action<ePresetType> <ChangeValuePresetDropdownCallback>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private Action<Boolean> <OnBindingCallback>k__BackingField; //Field offset: 0x1D4

	public Action<ePresetType> ChangeValuePresetDropdownCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Boolean> OnBindingCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32> OnPressButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GameObject PresetDropdown
	{
		 get { } //Length: 32
	}

	public ePresetType PresetType
	{
		 get { } //Length: 14
	}

	private GameObject TabDanmaku
	{
		private get { } //Length: 32
	}

	private GameObject TabKagura
	{
		private get { } //Length: 32
	}

	private static SettingKeyConfigDisp() { }

	public SettingKeyConfigDisp() { }

	public void ApplyBinds() { }

	public void CallbackBindingButton(int button_id) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void CallbackSelect(int button_id, BaseEventData _data) { }

	private void ChangePriset(int _value) { }

	public bool CheckBindingNullKey() { }

	public virtual void Create(LayerBase parent_layer) { }

	private string CulcDanmakuActionName(string _action, int id) { }

	[CompilerGenerated]
	public Action<ePresetType> get_ChangeValuePresetDropdownCallback() { }

	[CompilerGenerated]
	private Action<Boolean> get_OnBindingCallback() { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	public GameObject get_PresetDropdown() { }

	public ePresetType get_PresetType() { }

	private GameObject get_TabDanmaku() { }

	private GameObject get_TabKagura() { }

	public string GetCustomBind() { }

	public virtual void ImmediateOpen(bool visible) { }

	protected virtual void InitUguiOther() { }

	public void InputActionCustomJson(string _json) { }

	private void KeyBindCallback(string _action, string _override, DeviceType _type) { }

	protected virtual void LateUpdate() { }

	private void OnChangeValuePresetDropdown(int _value) { }

	private void OnEndBinding() { }

	protected virtual void OnSelected(BaseEventData _data) { }

	private void OnStartBinding() { }

	public void OverrideCustomKey(string _json) { }

	public virtual void ReleaseAll() { }

	public void ReloadBinds() { }

	public void ResetBinds() { }

	public void ResetCursor() { }

	public List<GameObject> SelectedList() { }

	[CompilerGenerated]
	public void set_ChangeValuePresetDropdownCallback(Action<ePresetType> value) { }

	[CompilerGenerated]
	public void set_OnBindingCallback(Action<Boolean> value) { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	private void SetTargetButtonTabDown() { }

	public void Setup(SetupParam _param) { }

	private void UpdateBindingButtonEnable() { }

	public virtual void UpdateButtonHit(bool _enable) { }

	private void UpdateCustomBind() { }

	protected virtual void UpdateDispMain() { }

	private void UpdateInputBindingWork() { }

	private void UpdateViewBindingButton() { }

}

