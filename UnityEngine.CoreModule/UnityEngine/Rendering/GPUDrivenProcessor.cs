namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
[RequiredByNativeCode]
internal class GPUDrivenProcessor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__34_0(in GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

		internal void <.cctor>b__34_1(in GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }

	}

	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; //Field offset: 0x0
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; //Field offset: 0x4
	internal IntPtr m_Ptr; //Field offset: 0x8

	private static GPUDrivenProcessor() { }

}

