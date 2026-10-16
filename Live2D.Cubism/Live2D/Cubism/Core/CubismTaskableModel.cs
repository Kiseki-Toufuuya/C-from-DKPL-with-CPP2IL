namespace Live2D.Cubism.Core;

internal sealed class CubismTaskableModel : ICubismTask
{
	private enum TaskState
	{
		Idle = 0,
		Enqueued = 1,
		Executing = 2,
		Executed = 3,
	}

	[CompilerGenerated]
	private CubismUnmanagedModel <UnmanagedModel>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CubismMoc <Moc>k__BackingField; //Field offset: 0xC
	private CubismDynamicDrawableData[] _dynamicDrawableData; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ShouldReleaseUnmanaged>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private object <Lock>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private TaskState <State>k__BackingField; //Field offset: 0x1C

	public bool DidExecute
	{
		 get { } //Length: 53
	}

	public private CubismDynamicDrawableData[] DynamicDrawableData
	{
		 get { } //Length: 52
		private set { } //Length: 27
	}

	public bool IsExecuting
	{
		 get { } //Length: 85
	}

	private object Lock
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private CubismMoc Moc
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private bool ShouldReleaseUnmanaged
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private TaskState State
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private CubismUnmanagedModel UnmanagedModel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismTaskableModel(CubismMoc moc) { }

	public static CubismTaskableModel CreateTaskableModel(CubismMoc moc) { }

	private void Execute() { }

	public bool get_DidExecute() { }

	public CubismDynamicDrawableData[] get_DynamicDrawableData() { }

	public bool get_IsExecuting() { }

	[CompilerGenerated]
	private object get_Lock() { }

	[CompilerGenerated]
	public CubismMoc get_Moc() { }

	[CompilerGenerated]
	private bool get_ShouldReleaseUnmanaged() { }

	[CompilerGenerated]
	private TaskState get_State() { }

	[CompilerGenerated]
	public CubismUnmanagedModel get_UnmanagedModel() { }

	private override void Live2D.Cubism.Core.ICubismTask.Execute() { }

	private void OnReleaseUnmanaged() { }

	public void ReleaseUnmanaged() { }

	private void set_DynamicDrawableData(CubismDynamicDrawableData[] value) { }

	[CompilerGenerated]
	private void set_Lock(object value) { }

	[CompilerGenerated]
	private void set_Moc(CubismMoc value) { }

	[CompilerGenerated]
	private void set_ShouldReleaseUnmanaged(bool value) { }

	[CompilerGenerated]
	private void set_State(TaskState value) { }

	[CompilerGenerated]
	private void set_UnmanagedModel(CubismUnmanagedModel value) { }

	public bool TryReadParameters(CubismParameter[] parameters) { }

	public bool TryWriteParametersAndParts(CubismParameter[] parameters, CubismPart[] parts) { }

	public void Update() { }

	public bool UpdateNow() { }

}

