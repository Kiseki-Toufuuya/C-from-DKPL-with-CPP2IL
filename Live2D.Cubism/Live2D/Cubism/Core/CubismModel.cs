namespace Live2D.Cubism.Core;

[CubismDontMoveOnReimport]
[ExecuteInEditMode]
public sealed class CubismModel : MonoBehaviour
{
	internal sealed class DynamicDrawableDataHandler : MulticastDelegate
	{

		public DynamicDrawableDataHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CubismModel sender, CubismDynamicDrawableData[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CubismModel sender, CubismDynamicDrawableData[] data) { }

	}

	private static Action _modelUpdateFunctions; //Field offset: 0x0
	[CompilerGenerated]
	private DynamicDrawableDataHandler OnDynamicDrawableData; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private CubismMoc _moc; //Field offset: 0x14
	[CompilerGenerated]
	private CubismTaskableModel <TaskableModel>k__BackingField; //Field offset: 0x18
	private CubismParameter[] _parameters; //Field offset: 0x1C
	private CubismPart[] _parts; //Field offset: 0x20
	private CubismDrawable[] _drawables; //Field offset: 0x24
	private CubismCanvasInformation _canvasInformation; //Field offset: 0x28
	private CubismParameterStore _parameterStore; //Field offset: 0x2C
	[SerializeField]
	private bool _isOverriddenParameterRepeat; //Field offset: 0x30
	[CompilerGenerated]
	private bool <WasAttachedModelUpdateFunction>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private bool <WasJustEnabled>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private int <LastTick>k__BackingField; //Field offset: 0x34

	public event DynamicDrawableDataHandler OnDynamicDrawableData
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	private bool CanRevive
	{
		private get { } //Length: 75
	}

	public private CubismCanvasInformation CanvasInformation
	{
		 get { } //Length: 30
		private set { } //Length: 27
	}

	public private CubismDrawable[] Drawables
	{
		 get { } //Length: 30
		private set { } //Length: 27
	}

	public bool IsRevived
	{
		 get { } //Length: 15
	}

	private int LastTick
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private CubismMoc Moc
	{
		 get { } //Length: 11
		private set { } //Length: 27
	}

	public private CubismParameter[] Parameters
	{
		 get { } //Length: 30
		private set { } //Length: 27
	}

	public private CubismPart[] Parts
	{
		 get { } //Length: 30
		private set { } //Length: 27
	}

	private CubismTaskableModel TaskableModel
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private bool WasAttachedModelUpdateFunction
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private bool WasJustEnabled
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CubismModel() { }

	[CompilerGenerated]
	public void add_OnDynamicDrawableData(DynamicDrawableDataHandler value) { }

	public void ForceUpdateNow() { }

	private bool get_CanRevive() { }

	public CubismCanvasInformation get_CanvasInformation() { }

	public CubismDrawable[] get_Drawables() { }

	public bool get_IsRevived() { }

	[CompilerGenerated]
	private int get_LastTick() { }

	public CubismMoc get_Moc() { }

	public CubismParameter[] get_Parameters() { }

	public CubismPart[] get_Parts() { }

	[CompilerGenerated]
	private CubismTaskableModel get_TaskableModel() { }

	[CompilerGenerated]
	private bool get_WasAttachedModelUpdateFunction() { }

	[CompilerGenerated]
	private bool get_WasJustEnabled() { }

	public bool GetOverrideFlagForModelParameterRepeat() { }

	public static CubismModel InstantiateFrom(CubismMoc moc) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static void OnModelsUpdate() { }

	private void OnModelUpdate() { }

	private void OnRenderObject() { }

	private void OnValidate() { }

	public void RefreshParameterStore() { }

	[RuntimeInitializeOnLoadMethod]
	private static void RegisterCallbackFunction() { }

	[CompilerGenerated]
	public void remove_OnDynamicDrawableData(DynamicDrawableDataHandler value) { }

	private void Reset(CubismMoc moc) { }

	public static void ResetMocReference(CubismModel model, CubismMoc moc) { }

	private void Revive() { }

	private void set_CanvasInformation(CubismCanvasInformation value) { }

	private void set_Drawables(CubismDrawable[] value) { }

	[CompilerGenerated]
	private void set_LastTick(int value) { }

	private void set_Moc(CubismMoc value) { }

	private void set_Parameters(CubismParameter[] value) { }

	private void set_Parts(CubismPart[] value) { }

	[CompilerGenerated]
	private void set_TaskableModel(CubismTaskableModel value) { }

	[CompilerGenerated]
	private void set_WasAttachedModelUpdateFunction(bool value) { }

	[CompilerGenerated]
	private void set_WasJustEnabled(bool value) { }

	public void SetOverrideFlagForModelParameterRepeat(bool isRepeat) { }

	private void Update() { }

}

