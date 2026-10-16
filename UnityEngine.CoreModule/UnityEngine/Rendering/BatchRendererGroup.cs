namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode]
public class BatchRendererGroup
{
	internal sealed class OnFinishedCulling : MulticastDelegate
	{

		public OnFinishedCulling(object object, IntPtr method) { }

		public override void Invoke(IntPtr customCullingResult) { }

	}

	internal sealed class OnPerformCulling : MulticastDelegate
	{

		public OnPerformCulling(object object, IntPtr method) { }

		public override JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	}

	private IntPtr m_GroupHandle; //Field offset: 0x8
	private OnPerformCulling m_PerformCulling; //Field offset: 0xC
	private OnFinishedCulling m_FinishedCulling; //Field offset: 0x10

	[RequiredByNativeCode]
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }

	[RequiredByNativeCode]
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

}

