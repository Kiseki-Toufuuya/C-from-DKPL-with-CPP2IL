namespace Heqet;

public class SettingDispBase : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public SettingDispBase <>4__this; //Field offset: 0x8
		public int _id; //Field offset: 0xC

		public <>c__DisplayClass62_0() { }

		internal void <RegistSlider>b__0(float _value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public SettingDispBase <>4__this; //Field offset: 0x8
		public int _id; //Field offset: 0xC

		public <>c__DisplayClass68_0() { }

		internal void <RegistDropdown>b__0(int _value) { }

		internal void <RegistDropdown>b__1(BaseEventData _data) { }

		internal void <RegistDropdown>b__2(BaseEventData _data) { }

	}

	[CompilerGenerated]
	private struct <Open>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public SettingDispBase <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eSpeedType
	{
		Manual = 0,
		Auto = 1,
		Easy = 2,
	}

	internal class HelpMessageWork
	{
		public List<GameObject> TargetObjects; //Field offset: 0x8
		public string MessagemapLabel; //Field offset: 0xC

		public HelpMessageWork() { }

		public void AddTargetObject(GameObject _obj) { }

	}

	internal class HeqetNavigation
	{
		public string tab; //Field offset: 0x8
		public GameObject target; //Field offset: 0xC
		public List<String> Navigations; //Field offset: 0x10

		public HeqetNavigation() { }

	}

	internal class HeqetNavigationObject
	{
		public string name; //Field offset: 0x8
		public string pass; //Field offset: 0xC
		public GameObject target; //Field offset: 0x10

		public HeqetNavigationObject() { }

	}

	internal class HeqetNavigationTest
	{
		public string tab; //Field offset: 0x8
		public List<HeqetNavigationObject> Navigations; //Field offset: 0xC

		public HeqetNavigationTest() { }

		public List<String> PassList() { }

	}

	internal class RadioButomWork
	{
		[CompilerGenerated]
		private Sprite <TextureOn>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Sprite <TextureOff>k__BackingField; //Field offset: 0xC
		public List<AtlasImage> Images; //Field offset: 0x10

		public private Sprite TextureOff
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public private Sprite TextureOn
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public RadioButomWork() { }

		[CompilerGenerated]
		private Sprite get_TextureOff() { }

		[CompilerGenerated]
		private Sprite get_TextureOn() { }

		[CompilerGenerated]
		public void set_TextureOff(Sprite value) { }

		[CompilerGenerated]
		public void set_TextureOn(Sprite value) { }

		public void UpdateParam(int _index) { }

	}

	public readonly int BASE_BPM; //Field offset: 0x114
	protected Animator RootAnimator; //Field offset: 0x118
	protected Dictionary<Int32, Slider> m_SliderDic; //Field offset: 0x11C
	protected Dictionary<Int32, UIWrapperTextMeshPro> m_SliderTextDic; //Field offset: 0x120
	protected Dictionary<Int32, RadioButomWork> m_RadioButtonDic; //Field offset: 0x124
	protected Dictionary<Int32, TMP_Dropdown> m_DropdownDic; //Field offset: 0x128
	protected List<HelpMessageWork> m_HelpMessageWorks; //Field offset: 0x12C
	protected List<UIWrapperBase> m_body_list; //Field offset: 0x130
	protected List<UIWrapperBase> m_tab_list; //Field offset: 0x134
	protected int m_current_body_id; //Field offset: 0x138
	protected UIWrapperBase m_curren_body_layer; //Field offset: 0x13C
	protected UIWrapperTextMeshPro m_HelpText; //Field offset: 0x140
	protected CriAtomExPlayback m_SliderSeHandle; //Field offset: 0x144
	protected CriAtomExPlayback m_TabSeHandle; //Field offset: 0x148
	[CompilerGenerated]
	private Action<Int32> <OnChangeBodyCallback>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonCallback>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Action<Int32, Single> <OnChangeSliderValueCallback>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private Action<Int32, Int32> <OnChangeRadioButtonValueCallback>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Action<Int32, Int32> <OnChangeDropdownValueCallback>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Action <OnSubmitDropdown>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Action <OnSelectedDropdown>k__BackingField; //Field offset: 0x164
	[CompilerGenerated]
	private Action<Int32> <OnPointerClickDropdown>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private Action<Boolean> <ImmediateOpenCallback>k__BackingField; //Field offset: 0x16C

	public Action<Boolean> ImmediateOpenCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32> OnChangeBodyCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32, Int32> OnChangeDropdownValueCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32, Int32> OnChangeRadioButtonValueCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32, Single> OnChangeSliderValueCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32> OnPointerClickDropdown
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action<Int32> OnPressButtonCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action OnSelectedDropdown
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Action OnSubmitDropdown
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public SettingDispBase() { }

	[CompilerGenerated]
	private bool <Open>b__70_0() { }

	public void AddSliderValue(int _id, float _value) { }

	protected float CalcDecimal(float _value, int _dec) { }

	public override void CallbackSelect(int _id, BaseEventData _data) { }

	protected void ChangeBody(int next_id) { }

	public override void ClearTabActive() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DropdownHide() { }

	[CompilerGenerated]
	public Action<Boolean> get_ImmediateOpenCallback() { }

	[CompilerGenerated]
	protected Action<Int32> get_OnChangeBodyCallback() { }

	[CompilerGenerated]
	protected Action<Int32, Int32> get_OnChangeDropdownValueCallback() { }

	[CompilerGenerated]
	protected Action<Int32, Int32> get_OnChangeRadioButtonValueCallback() { }

	[CompilerGenerated]
	protected Action<Int32, Single> get_OnChangeSliderValueCallback() { }

	[CompilerGenerated]
	protected Action<Int32> get_OnPointerClickDropdown() { }

	[CompilerGenerated]
	protected Action<Int32> get_OnPressButtonCallback() { }

	[CompilerGenerated]
	protected Action get_OnSelectedDropdown() { }

	[CompilerGenerated]
	protected Action get_OnSubmitDropdown() { }

	public override void ImmediateOpen(bool visible) { }

	protected virtual void LateUpdate() { }

	protected override void OnChangeDropdownValue(int _id, int _value) { }

	protected override void OnChangeRadioButtonValue(int _id, int _index) { }

	protected override void OnChangeSliderValue(int _id, float _value, int _decimal = 1) { }

	protected override void OnClickButton(int button_id) { }

	protected override void OnSelectDropdown(BaseEventData _data) { }

	protected override void OnSelected(BaseEventData _data) { }

	protected override void OnSelectedTab(BaseEventData _data) { }

	[AsyncStateMachine(typeof(<Open>d__70))]
	public UniTask Open(bool visible) { }

	protected CriAtomExPlayback PlaySoundStart(ALL_SE _sound) { }

	protected TMP_Dropdown RegistDropdown(int _id, int _dropdownId) { }

	protected void RegistRadioButton(int _id, int _radioButtonId, int _imageId) { }

	protected Slider RegistSlider(int _id, int _sliderId, int _textId) { }

	[CompilerGenerated]
	public void set_ImmediateOpenCallback(Action<Boolean> value) { }

	[CompilerGenerated]
	public void set_OnChangeBodyCallback(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_OnChangeDropdownValueCallback(Action<Int32, Int32> value) { }

	[CompilerGenerated]
	public void set_OnChangeRadioButtonValueCallback(Action<Int32, Int32> value) { }

	[CompilerGenerated]
	public void set_OnChangeSliderValueCallback(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void set_OnPointerClickDropdown(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_OnPressButtonCallback(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_OnSelectedDropdown(Action value) { }

	[CompilerGenerated]
	public void set_OnSubmitDropdown(Action value) { }

	public void SetSliderValueWithoutNotify(int _id, float _value) { }

	public void SetTargetTabDown(GameObject _obj, GameObject _target) { }

	public void SetTargetTabUp(GameObject _obj, GameObject _target) { }

	protected void UpdateBodyParam(int id) { }

	public override void UpdateButtonHit(bool _enable) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateDoropdownOptipons(int _id, List<String> _options) { }

	public override void UpdateDropdownValueWithoutNotify(int _id, int _value) { }

	protected void UpdateHelpText(GameObject selected = null) { }

	protected void UpdateNavigation(Selectable _select, List<Selectable> _targets) { }

	public void UpdateRadioButtonValue(int _id, int _index) { }

	public void UpdateSliderValueText(int _id, float _value) { }

	public override void UpdateSliderValueWithoutNotify(int _id, float _value, int _decimal) { }

	protected void UpdateTabActive(int _id) { }

	protected void UpdateTabActive() { }

}

