namespace Heqet;

public class SaveDataErrorDialogLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<ButtonType> <>9__17_0; //Field offset: 0x4
		public static Action <>9__17_1; //Field offset: 0x8
		public static Action <>9__17_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal void <InitUpdateBefore>b__17_0(ButtonType btnId) { }

		internal void <InitUpdateBefore>b__17_1() { }

		internal void <InitUpdateBefore>b__17_2() { }

	}

	internal enum eDialogType
	{
		System = 0,
		Game = 1,
	}

	private enum eMainStep
	{
		WAIT_DIALOG = 0,
		NONE = 1,
	}

	internal enum eResult
	{
		Continue = 0,
		Retry = 1,
	}

	private static string DIALOG_TAG; //Field offset: 0x0
	[CompilerGenerated]
	private static eResult <LastResult>k__BackingField; //Field offset: 0x4
	private eMainStep m_MainStep; //Field offset: 0x58
	private eDialogType m_DialogType; //Field offset: 0x5C

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public private static eResult LastResult
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 80
	}

	private static SaveDataErrorDialogLayer() { }

	public SaveDataErrorDialogLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public static eResult get_LastResult() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	private static void set_LastResult(eResult value) { }

	protected virtual void Update(bool is_active) { }

}

