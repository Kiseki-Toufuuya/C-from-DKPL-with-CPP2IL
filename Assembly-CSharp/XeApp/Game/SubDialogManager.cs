namespace XeApp.Game;

public class SubDialogManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public sDialogArg task; //Field offset: 0x8

		public <>c__DisplayClass7_0() { }

		internal void <OnCreate>b__0(LayerBase layer) { }

	}

	private enum eStep
	{
		NONE = 0,
		CREATE = 1,
		INIT = 2,
		DISP = 3,
		OUT_ANIM = 4,
	}

	public static SubDialogManager Instance; //Field offset: 0x0
	private eStep m_Step; //Field offset: 0x8
	private List<sDialogArg> m_DialogTaskList; //Field offset: 0xC

	public SubDialogManager() { }

	public void AddBackKeyBtn(string tag, ButtonType btn) { }

	public void AddDialogTask(eDialogType type, eDialogSize size, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogChildArg childArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogListArg listArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eCanvas canvas = 3, eSeType seType = 0, Transform parentTransform = null) { }

	public void AddDialogTask(sDialogInutChildArg inputArg, eDialogType type, string tag, string title = null, string text = null, String[] buttonText = null, bool bkMask = true, bool disableScrBtn = false, Action<ButtonType> callback = null, Action inAnimationCallback = null, Action outAnimationCallback = null, eSeType seType = 0) { }

	public void ClearDialogList() { }

	public void CloseCurrentDialog() { }

	public void Create() { }

	public bool IsDestroy(string tag) { }

	private void OnCreate(sDialogArg task) { }

	public void SetButtonMaskFg(string tag, ButtonType button, bool inUse) { }

	public void SetButtonSe(string tag, ButtonType button, ALL_SE seCueId) { }

	public void SetEmphasisButtonImageUseFg(string tag, ButtonType button, bool inUse) { }

	public void SetFukidashiButtonUseFg(string tag, int num, eSpriteType type, bool not_enough = false) { }

	public void SetNormalButtonImageUseFg(string tag, ButtonType button, bool inUse) { }

	private void SetStep(eStep step) { }

	public void Update() { }

}

