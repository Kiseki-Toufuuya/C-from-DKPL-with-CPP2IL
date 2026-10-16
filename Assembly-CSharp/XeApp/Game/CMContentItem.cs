namespace XeApp.Game;

public class CMContentItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public OnTap onTap; //Field offset: 0x8
		public int id; //Field offset: 0xC

		public <>c__DisplayClass33_0() { }

		internal void <InitButton>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public OnChangeBool onChangeValue; //Field offset: 0x8
		public int id; //Field offset: 0xC

		public <>c__DisplayClass34_0() { }

		internal void <InitToggle>b__0(bool v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public CMContentItem <>4__this; //Field offset: 0x8
		public OnGetString onGetString; //Field offset: 0xC
		public int id; //Field offset: 0x10
		public OnInputValidation onInputValidation; //Field offset: 0x14
		public OnChangeString onChangeString; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <InitInputField>b__0() { }

		internal void <InitInputField>b__1(string v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public CMContentItem <>4__this; //Field offset: 0x8
		public OnGetString onGetString; //Field offset: 0xC
		public int id; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal void <InitUpdateLabel>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public OnChangeFloat onChangeFloat; //Field offset: 0x8
		public int id; //Field offset: 0xC
		public bool isWholeNumbers; //Field offset: 0x10
		public CMContentItem <>4__this; //Field offset: 0x14
		public OnGetFloat onGetFloat; //Field offset: 0x18

		public <>c__DisplayClass39_0() { }

		internal void <InitSlider>b__0(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public OnDropdownValueChanged onValueChanged; //Field offset: 0x8
		public CMContentItem <>4__this; //Field offset: 0xC

		public <>c__DisplayClass40_0() { }

		internal void <InitDropdown>b__0(int <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public OnTap onTap; //Field offset: 0x8
		public int id; //Field offset: 0xC
		public ICMItemControl itemControl; //Field offset: 0x10
		public int category; //Field offset: 0x14
		public CMContentItem <>4__this; //Field offset: 0x18
		public Action updateValueText; //Field offset: 0x1C

		public <>c__DisplayClass54_0() { }

		internal void <InitItemEdit>b__0() { }

		internal void <InitItemEdit>b__1() { }

		internal void <InitItemEdit>b__2() { }

		internal void <InitItemEdit>b__3() { }

		internal void <InitItemEdit>b__4() { }

	}

	internal struct InputInfo
	{
		public int Trg; //Field offset: 0x0
		public int Cnd; //Field offset: 0x4
		public int Rpeat; //Field offset: 0x8

	}

	internal sealed class OnChangeBool : MulticastDelegate
	{

		public OnChangeBool(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool val, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, bool val) { }

	}

	internal sealed class OnChangeFloat : MulticastDelegate
	{

		public OnChangeFloat(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, float val, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, float val) { }

	}

	internal sealed class OnChangeString : MulticastDelegate
	{

		public OnChangeString(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, string val, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, string val) { }

	}

	internal sealed class OnDropdownValueChanged : MulticastDelegate
	{

		public OnDropdownValueChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Dropdown dd, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Dropdown dd) { }

	}

	internal sealed class OnGetBool : MulticastDelegate
	{

		public OnGetBool(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(int id) { }

	}

	internal sealed class OnGetFloat : MulticastDelegate
	{

		public OnGetFloat(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke(int id) { }

	}

	internal sealed class OnGetString : MulticastDelegate
	{

		public OnGetString(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke(int id) { }

	}

	internal sealed class OnInputValidation : MulticastDelegate
	{

		public OnInputValidation(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string val, AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke(string val) { }

	}

	internal sealed class OnTap : MulticastDelegate
	{

		public OnTap(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id) { }

	}

	[SerializeField]
	private Text TextTitle; //Field offset: 0x10
	[SerializeField]
	private Text TextValue; //Field offset: 0x14
	[SerializeField]
	private Button ButtonOn; //Field offset: 0x18
	[SerializeField]
	private Toggle ToggleFlip; //Field offset: 0x1C
	[SerializeField]
	private InputField InputFiledUserInput; //Field offset: 0x20
	[SerializeField]
	private Slider SliderValue; //Field offset: 0x24
	[SerializeField]
	private Text SliderText; //Field offset: 0x28
	[SerializeField]
	private Text TextID; //Field offset: 0x2C
	[SerializeField]
	private Text TextCount; //Field offset: 0x30
	[SerializeField]
	private Button ButtonMax; //Field offset: 0x34
	[SerializeField]
	private Button ButtonPlus; //Field offset: 0x38
	[SerializeField]
	private Button ButtonMinus; //Field offset: 0x3C
	[SerializeField]
	private Button ButtonMin; //Field offset: 0x40
	[SerializeField]
	private Dropdown DropDown; //Field offset: 0x44
	private Action InputUpdater; //Field offset: 0x48
	private Action ValueUpdater; //Field offset: 0x4C
	private Action InputOnEnable; //Field offset: 0x50
	private int frame; //Field offset: 0x54
	[CompilerGenerated]
	private int <updateFrame>k__BackingField; //Field offset: 0x58
	private InputInfo inputInfo; //Field offset: 0x5C
	private int rawInput; //Field offset: 0x68
	private int prevInput; //Field offset: 0x6C
	private int boost; //Field offset: 0x70
	private int waitCount; //Field offset: 0x74
	private int rpeatCount; //Field offset: 0x78
	private int prevValue; //Field offset: 0x7C

	public int updateFrame
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CMContentItem() { }

	[CompilerGenerated]
	public int get_updateFrame() { }

	public void InitButton(string title, string s, OnTap onTap, int id) { }

	public void InitDropdown(string title, List<String> option, int value, OnDropdownValueChanged onValueChanged) { }

	public void InitInputField(string title, OnChangeString onChangeString, OnGetString onGetString, int id, OnInputValidation onInputValidation = null) { }

	public void InitItemEdit(string title, string idText, bool showMinusPlus, bool showMax, ICMItemControl itemControl, int category, int id, OnTap onTap) { }

	public void InitSlider(string title, OnChangeFloat onChangeFloat, OnGetFloat onGetFloat, int id, float minVal, float maxVal, bool isWholeNumbers) { }

	public void InitStaticLabel(string title, string s, int id) { }

	public void InitStaticLabel(string title, string s, int id, string idText) { }

	public void InitToggle(string title, OnChangeBool onChangeValue, OnGetBool onGetBool, int id) { }

	public void InitUpdateLabel(string title, OnGetString onGetString, int id) { }

	private void InputUpdate() { }

	private void OnEnable() { }

	public void OnMinusDown() { }

	public void OnMinusUp() { }

	public void OnPlusDown() { }

	public void OnPlusUp() { }

	[CompilerGenerated]
	public void set_updateFrame(int value) { }

	private void Update() { }

}

