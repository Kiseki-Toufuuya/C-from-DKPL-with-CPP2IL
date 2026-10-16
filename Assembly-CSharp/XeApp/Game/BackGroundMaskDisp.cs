namespace XeApp.Game;

public class BackGroundMaskDisp : DispBase
{
	private class BackGroundMaskDispImpl : BackGroundMaskDispImplBase
	{
		private BackGroundMaskDisp Disp; //Field offset: 0x8
		private Image MaskImage; //Field offset: 0xC
		private Animator BkAnimator; //Field offset: 0x10

		public BackGroundMaskDispImpl() { }

		private void CallbackButton(int id) { }

		public override void CallbackInitLayout() { }

		private bool CallbackInputEnable(int id) { }

		public override void Close() { }

		public override void Create(LayerBase parent_layer) { }

		public override void Initialize(BackGroundMaskDisp disp) { }

		public override void InitUguiOther() { }

		public override void LateUpdate() { }

		public override void Open(bool soon = false) { }

		public override void SetActive(bool enable) { }

		public override void SetAlpha(float alpha) { }

		public override void SetButtonHit(bool enable) { }

	}

	private interface BackGroundMaskDispImplBase
	{

		public void CallbackInitLayout() { }

		public void Close() { }

		public void Create(LayerBase parent_layer) { }

		public void Initialize(BackGroundMaskDisp disp) { }

		public void InitUguiOther() { }

		public void LateUpdate() { }

		public void Open(bool soon = false) { }

		public void SetActive(bool enable) { }

		public void SetAlpha(float alpha) { }

		public void SetButtonHit(bool enable) { }

	}

	internal enum eButtonId
	{
		NONE = -1,
		SCR_BTN = 0,
		NUM = 1,
	}

	private class IngameBackGroundMaskDispImpl : BackGroundMaskDispImplBase
	{
		private BackGroundMaskDisp Disp; //Field offset: 0x8
		private Image MaskImage; //Field offset: 0xC
		private Animator BkAnimator; //Field offset: 0x10

		public IngameBackGroundMaskDispImpl() { }

		public override void CallbackInitLayout() { }

		public override void Close() { }

		public override void Create(LayerBase parent_layer) { }

		public override void Initialize(BackGroundMaskDisp disp) { }

		public override void InitUguiOther() { }

		public override void LateUpdate() { }

		public override void Open(bool soon = false) { }

		public override void SetActive(bool enable) { }

		public override void SetAlpha(float alpha) { }

		public override void SetButtonHit(bool enable) { }

	}

	private BackGroundMaskDispImplBase impl; //Field offset: 0x114
	private bool isIngame; //Field offset: 0x118
	private eButtonId pushBtn; //Field offset: 0x11C

	public bool IsIngame
	{
		 set { } //Length: 17
	}

	public eButtonId PushBtn
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public BackGroundMaskDisp() { }

	public void AddBackKeyCallBack() { }

	private void CallbackInitLayout() { }

	public void Close() { }

	public virtual void Create(LayerBase parent_layer) { }

	public eButtonId get_PushBtn() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void Open(bool soon = false) { }

	public void set_IsIngame(bool value) { }

	public void set_PushBtn(eButtonId value) { }

	public void SetActive(bool enable) { }

	public void SetAlpha(float alpha) { }

	public void SetHitButton(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

