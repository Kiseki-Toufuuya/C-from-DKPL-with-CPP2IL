namespace Heqet;

public class ReadStoryDialogLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__26_1; //Field offset: 0x4
		public static Action <>9__26_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Open>b__26_1() { }

		internal void <Open>b__26_2() { }

	}

	internal enum eButtonId
	{
		Ok = 0,
		Cancel = 1,
		Max = 2,
	}

	private enum eContStep
	{
		MAIN = 0,
		NONE = 1,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		OTHER_LAYER = 5,
		NONE = 6,
	}

	[CompilerGenerated]
	private bool <IsOk>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; //Field offset: 0x59
	private eMainStep m_MainStep; //Field offset: 0x5C
	private eContStep m_ContStep; //Field offset: 0x60

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

	public private bool IsCancel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsOk
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ReadStoryDialogLayer() { }

	[CompilerGenerated]
	private void <Open>b__26_0(ButtonType btnId) { }

	private void Cancel() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public bool get_IsCancel() { }

	[CompilerGenerated]
	public bool get_IsOk() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	private void ReadStory() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	private void set_IsOk(bool value) { }

	protected virtual void Update(bool is_active) { }

}

