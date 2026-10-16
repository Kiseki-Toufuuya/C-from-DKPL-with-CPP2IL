namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	private static bool s_CleanUpPipeline; //Field offset: 0x0
	private static string s_CurrentPipelineType; //Field offset: 0x4
	private static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x8
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineCreated; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x1C

	public private static RenderPipeline currentPipeline
	{
		 get { } //Length: 61
		private set { } //Length: 186
	}

	private static bool isCurrentPipelineValid
	{
		private get { } //Length: 125
	}

	private static RenderPipelineManager() { }

	[RequiredByNativeCode]
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, object renderRequest) { }

	public static RenderPipeline get_currentPipeline() { }

	private static bool get_isCurrentPipelineValid() { }

	[RequiredByNativeCode]
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	private static bool IsPipelineRequireCreation() { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset) { }

	private static void set_currentPipeline(RenderPipeline value) { }

	internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

}

