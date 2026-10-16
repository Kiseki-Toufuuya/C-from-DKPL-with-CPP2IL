namespace UnityEngine.Rendering;

[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private struct CullShadowCastersContext
	{
		public IntPtr cullResults; //Field offset: 0x0
		public ShadowSplitData* splitBuffer; //Field offset: 0x4
		public int splitBufferLength; //Field offset: 0x8
		public LightShadowCasterCullingInfo* perLightInfos; //Field offset: 0xC
		public int perLightInfoCount; //Field offset: 0x10

	}

	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	private IntPtr m_Ptr; //Field offset: 0x0

	private static ScriptableRenderContext() { }

	internal ScriptableRenderContext(IntPtr ptr) { }

	public override bool Equals(ScriptableRenderContext other) { }

	public virtual bool Equals(object obj) { }

	internal void GetCameras(List<Camera> results) { }

	private void GetCameras_Internal(Type listType, object resultList) { }

	public virtual int GetHashCode() { }

}

