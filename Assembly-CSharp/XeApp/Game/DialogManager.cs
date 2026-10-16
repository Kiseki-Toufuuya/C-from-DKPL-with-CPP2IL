namespace XeApp.Game;

public class DialogManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public sDialogArg task; //Field offset: 0x8

		public <>c__DisplayClass17_0() { }

		internal void <OnCreate>b__0(LayerBase layer) { }

	}

	internal enum ButtonType
	{
		None = -1,
		Scr = 0,
		Btn01 = 1,
		Btn02 = 2,
		Btn03 = 3,
		Btn04 = 4,
		Btn05 = 5,
		Num = 6,
	}

	internal enum eDialogSize
	{
		Size_S = 0,
		Size_M = 1,
		Size_L = 2,
	}

	internal enum eDialogType
	{
		Ok = 0,
		YesNo = 1,
		YesNoIgnore = 2,
		SingleButton = 3,
		DoubleButton = 4,
		TripleButton = 5,
	}

	private enum eStep
	{
		NONE = 0,
		CREATE = 1,
		INIT = 2,
		DISP = 3,
		OUT_ANIM = 4,
	}

	internal class sDialogArg
	{
		public eDialogType DialogType; //Field offset: 0x8
		public eDialogSize DialogSize; //Field offset: 0xC
		public string Tag; //Field offset: 0x10
		public string Title; //Field offset: 0x14
		public string Text; //Field offset: 0x18
		public String[] ButtonText; //Field offset: 0x1C
		public Boolean[] ButtonEmpFlg; //Field offset: 0x20
		public Boolean[] ButtonNmlFlg; //Field offset: 0x24
		public Boolean[] ButtonNmlText; //Field offset: 0x28
		public ALL_SE[] ButtonSeCueId; //Field offset: 0x2C
		public eSeType SeType; //Field offset: 0x30
		public bool BackMask; //Field offset: 0x34
		public bool DisableScrBtn; //Field offset: 0x35
		public sDialogChildArg ChildArg; //Field offset: 0x38
		public sDialogListArg ListArg; //Field offset: 0x3C
		public sDialogInutChildArg InputArg; //Field offset: 0x40
		public Action<ButtonType> BtnCallBack; //Field offset: 0x44
		public Action InAnimationCallback; //Field offset: 0x48
		public Action OutAnimationCallback; //Field offset: 0x4C
		public DialogLayer m_Layer; //Field offset: 0x50
		public bool EnableFuki; //Field offset: 0x54
		public int numFuki; //Field offset: 0x58
		public eSpriteType typeFuki; //Field offset: 0x5C
		public bool NotEnoughFuki; //Field offset: 0x60
		public Boolean[] ButtonMaskFlg; //Field offset: 0x64
		public eCanvas m_Canvas; //Field offset: 0x68
		public ButtonType BackKeyBtn; //Field offset: 0x6C
		public Transform ParentTransform; //Field offset: 0x70
		public bool ForceSetButtonEnable; //Field offset: 0x74
		public bool SetButtonEnable; //Field offset: 0x75

		public sDialogArg(eDialogType type, eDialogSize size, string tag, string title, string text, String[] buttonText, bool bkMask, bool disableScrBtn, Action<ButtonType> callback, Action inAnimationCallback, Action outAnimationCallback, eCanvas canvas = 3, eSeType setype = 0, Transform parentTransform = null) { }

		public sDialogArg(sDialogChildArg childArg, eDialogType type, string tag, string title, string text, String[] buttonText, bool bkMask, bool disableScrBtn, Action<ButtonType> callback, Action inAnimationCallback, Action outAnimationCallback, eCanvas canvas = 3, eSeType setype = 0, Transform parentTransform = null) { }

		public sDialogArg(sDialogListArg listArg, eDialogType type, string tag, string title, string text, String[] buttonText, bool bkMask, bool disableScrBtn, Action<ButtonType> callback, Action inAnimationCallback, Action outAnimationCallback, eCanvas canvas = 3, eSeType setype = 0, Transform parentTransform = null) { }

		public sDialogArg(sDialogInutChildArg inputArg, eDialogType type, string tag, string title, string text, String[] buttonText, bool bkMask, bool disableScrBtn, Action<ButtonType> callback, Action inAnimationCallback, Action outAnimationCallback, eSeType setype = 0) { }

		private void SetButtonDefaultSe() { }

	}

	internal class sDialogChildArg
	{
		public int ChildID; //Field offset: 0x8
		public String[] Text; //Field offset: 0xC
		public String[] Image; //Field offset: 0x10
		public String[] Object; //Field offset: 0x14
		public object sendData; //Field offset: 0x18

		public sDialogChildArg(int childID, String[] text = null, String[] image = null, String[] objects = null, object send = null) { }

	}

	internal class sDialogInutChildArg
	{
		public int ChildID; //Field offset: 0x8
		public string Title; //Field offset: 0xC
		public string Info; //Field offset: 0x10
		public string InputTxt; //Field offset: 0x14
		public int InputLimit; //Field offset: 0x18
		public bool isTextCheck; //Field offset: 0x1C

		public sDialogInutChildArg(int childID, string title, string info, string inputTxt, int inputLimit = 15, bool isTextChk = false) { }

	}

	internal class sDialogListArg
	{
		public int ChildID; //Field offset: 0x8
		public List<sDialogPanelListArg> PanelList; //Field offset: 0xC

		public sDialogListArg(int childID, List<sDialogPanelListArg> panelList) { }

	}

	internal class sDialogPanelListArg
	{
		public int ItemPrefix; //Field offset: 0x8
		public int ItemValue; //Field offset: 0xC
		public String[] Text; //Field offset: 0x10
		public object sendData; //Field offset: 0x14

		public sDialogPanelListArg(int prefix, int value, String[] text = null, object send = null) { }

	}

	public static DialogManager Instance; //Field offset: 0x0
	private eStep m_Step; //Field offset: 0x8
	private List<sDialogArg> m_DialogTaskList; //Field offset: 0xC

	public bool IsTaskUpdate
	{
		 get { } //Length: 57
	}

	public DialogManager() { }

	public void AddBackKeyBtn(string tag, ButtonType btn) { }

	public void AddDialogTask(eDialogType type, eDialogSize size, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogChildArg childArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogListArg listArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogInutChildArg inputArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eSeType seType = 0) { }

	public void ClearDialogList() { }

	public void CloseCurrentDialog() { }

	public void Create() { }

	public bool get_IsTaskUpdate() { }

	public bool IsDestroy(string tag) { }

	private void OnCreate(sDialogArg task) { }

	public void SetButtonMaskFg(string tag, ButtonType button, bool inUse) { }

	public void SetButtonSe(string tag, ButtonType button, ALL_SE seCueId) { }

	public void SetEmphasisButtonImageUseFg(string tag, ButtonType button, bool inUse) { }

	public void SetFukidashiButtonUseFg(string tag, int num, eSpriteType type, bool not_enough = false) { }

	internal void SetItemIconButtonEnable(string tag, bool enable) { }

	public void SetNormalButtonImageUseFg(string tag, ButtonType button, bool inUse) { }

	public void SetNormalButtonText(string tag, ButtonType button, bool inUse) { }

	private void SetStep(eStep step) { }

	public void Update() { }

}

