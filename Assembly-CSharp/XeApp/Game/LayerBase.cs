namespace XeApp.Game;

public abstract class LayerBase
{
	[CompilerGenerated]
	private sealed class <Co_ErrorToTitle>d__116 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LayerBase <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_ErrorToTitle>d__116(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum eLayerStep
	{
		NONE = 0,
		BEFORE_ACCESS = 1,
		INIT_RESOURCE_START = 2,
		INIT_RESOURCE_WAIT = 3,
		INIT_SUB_RESOURCE_START = 4,
		INIT_SUB_RESOURCE_WAIT = 5,
		INIT_START = 6,
		WAIT_IN_ANIM = 7,
		UPDATE_MAIN = 8,
		END_MAIN = 9,
		AFTER_ACCESS = 10,
		WAIT_OUT_ANIM = 11,
		RELEASE_LAYER = 12,
		RELEASE_AFTER = 13,
		RESET = 14,
		END = 15,
	}

	internal enum eLayerSubStep
	{
		NONE = 0,
		INIT_RESOURCE_START = 1,
		INIT_RESOURCE_WAIT = 2,
		INIT_START = 3,
	}

	internal enum eLayerType
	{
		NORMAL = 0,
		FORCED_MOVE = 1,
		DIALOG = 2,
		HEADER = 3,
		SYSTEM = 4,
	}

	public static bool OptimizeEnable; //Field offset: 0x0
	private List<DispBase> m_DispList; //Field offset: 0x8
	private List<DispBase> m_AddDispList; //Field offset: 0xC
	private Dictionary<eLayerStep, Action> m_StepCallbackList; //Field offset: 0x10
	private int m_OrderId; //Field offset: 0x14
	private uint m_SequenceId; //Field offset: 0x18
	private object m_PrevArgument; //Field offset: 0x1C
	private string m_Tag; //Field offset: 0x20
	private LayerBase m_ParentLayer; //Field offset: 0x24
	private int m_CntStep; //Field offset: 0x28
	private bool m_IsTouch; //Field offset: 0x2C
	private bool m_SetReleaseFg; //Field offset: 0x2D
	private eLayerStep m_Step; //Field offset: 0x30
	private eLayerStep m_StepReq; //Field offset: 0x34
	private eLayerSubStep m_SubStep; //Field offset: 0x38
	private eLayerSubStep m_SubStepReq; //Field offset: 0x3C
	private bool m_IsHide; //Field offset: 0x40
	private Action m_layerStartCallback; //Field offset: 0x44
	private Action m_layerEndCallback; //Field offset: 0x48
	private List<DispBase> m_ForceHideDispList; //Field offset: 0x4C
	public Action<Boolean> m_onEnable; //Field offset: 0x50
	private bool m_IsActive; //Field offset: 0x54

	public abstract bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 0
	}

	public override bool IS_STATIC_LAYER
	{
		 get { } //Length: 3
	}

	public abstract bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 0
	}

	public abstract bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 0
	}

	public bool IsHide
	{
		 get { } //Length: 11
	}

	public override eLayerType LAYER_TYPE
	{
		 get { } //Length: 3
	}

	public Action LayerEndCallback
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Action LayerStartCallback
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int OrderId
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public private LayerBase Parent
	{
		 get { } //Length: 11
		private set { } //Length: 27
	}

	public private object PrevArgument
	{
		 get { } //Length: 11
		private set { } //Length: 27
	}

	public private uint SequenceId
	{
		 get { } //Length: 11
		private set { } //Length: 14
	}

	public private string Tag
	{
		 get { } //Length: 11
		private set { } //Length: 27
	}

	private static LayerBase() { }

	protected LayerBase() { }

	protected override bool AccessAfter() { }

	protected override bool AccessBefore() { }

	public void AccessBeforeStep() { }

	public T AddCreateDispBase(Action<DispBase> action = null, Transform parent = null) { }

	public T AddDispBase(Action<DispBase> action = null, Transform parent = null) { }

	private void AddDispList() { }

	public void AddStepCallback(eLayerStep step, Action callback) { }

	[IteratorStateMachine(typeof(<Co_ErrorToTitle>d__116))]
	private IEnumerator Co_ErrorToTitle() { }

	public void Create(int order, uint sequence) { }

	protected void DeletDispBase(DispBase disp) { }

	protected abstract bool EndUpdateAfter() { }

	protected void ErrorRequest() { }

	public override void ForceHideLayerDisp() { }

	public void ForceRelease() { }

	public abstract bool get_IS_DISP_BACKGROUND() { }

	public override bool get_IS_STATIC_LAYER() { }

	public abstract bool get_IS_TOUCH_BACKGROUND() { }

	public abstract bool get_IS_UPDATE_BACKGROUND() { }

	public bool get_IsHide() { }

	public override eLayerType get_LAYER_TYPE() { }

	public Action get_LayerEndCallback() { }

	public Action get_LayerStartCallback() { }

	public int get_OrderId() { }

	public LayerBase get_Parent() { }

	public object get_PrevArgument() { }

	public uint get_SequenceId() { }

	public string get_Tag() { }

	public bool GetTouch() { }

	protected abstract void InitAll() { }

	public void InitResouceStep() { }

	protected bool InitResourceStart() { }

	protected override bool InitResourceWait() { }

	protected bool InitSubDispResourceStart() { }

	protected override bool InitSubDispResourceWait() { }

	protected override bool InitSubDispUpdateBefore() { }

	protected bool InitSubResourceStart() { }

	protected override bool InitSubResourceWait() { }

	protected abstract bool InitUpdateBefore() { }

	public bool IsActiveLayer() { }

	public override bool IsDestroy() { }

	public override bool IsDestroyWait() { }

	public override bool IsReady() { }

	public override bool IsSubDispReady() { }

	protected abstract void LateUpdate(bool is_active) { }

	public override void LauncherTransition() { }

	public void LayerLateUpdate(bool is_active) { }

	public void LayerUpdate(bool is_active) { }

	private bool MainStepUpdate(bool is_active) { }

	protected override void OnErrorTitleReturn() { }

	protected override void OnSetDisp(bool enable) { }

	protected override void OnSetHide(bool enable) { }

	protected override void OnSetTouch(bool enable) { }

	public abstract void OverDeleteLayer() { }

	public void Release() { }

	protected abstract bool ReleaseLayer() { }

	public void Reset() { }

	public override void ResetForceHideLayerDisp() { }

	public void set_LayerEndCallback(Action value) { }

	public void set_LayerStartCallback(Action value) { }

	protected void set_OrderId(int value) { }

	private void set_Parent(LayerBase value) { }

	private void set_PrevArgument(object value) { }

	private void set_SequenceId(uint value) { }

	private void set_Tag(string value) { }

	public void SetArgument(object arg, string tag) { }

	public void SetDisp(bool enable) { }

	public void SetHide(bool enable) { }

	public void SetLayerActiveFlg(bool active) { }

	public void SetParentLayer(LayerBase layer) { }

	private void SetStep(eLayerStep step) { }

	private void SetSubStep(eLayerSubStep step) { }

	public void SetTouch(bool enable) { }

	private bool SubStepUpdate(bool is_active) { }

	public override void TransitionSetUp() { }

	protected abstract void Update(bool is_active) { }

	public void UpdateLayoutOrder(int order) { }

	private bool WaitAutoOutAnim() { }

	protected override bool WaitInAnim() { }

	protected override bool WaitOutAnim() { }

	protected override bool WaitReset() { }

}

