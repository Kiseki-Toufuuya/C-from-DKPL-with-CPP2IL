namespace Heqet.Title;

public class ResetDataLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<ButtonType> <>9__14_0; //Field offset: 0x4
		public static Action <>9__14_1; //Field offset: 0x8
		public static Action <>9__14_3; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal void <ButtonOnClick>b__14_0(ButtonType btn) { }

		internal void <ButtonOnClick>b__14_1() { }

		internal void <ButtonOnClick>b__14_3() { }

	}

	private ResetDataDisp m_ResetDataDisp; //Field offset: 0x58

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

	public ResetDataLayer() { }

	[CompilerGenerated]
	private void <ButtonOnClick>b__14_2() { }

	[CompilerGenerated]
	private void <ButtonOnClick>b__14_4() { }

	private void ButtonOnClick(int button_id) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

